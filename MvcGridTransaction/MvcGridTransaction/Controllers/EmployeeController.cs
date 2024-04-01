using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using MvcGridTransaction.Models;
using TEMS_SAP.Functions;
using System.Text.RegularExpressions;


namespace MvcGridTransaction.Controllers
{
    public class EmployeeController : MyController
    {
            //


        public ActionResult Index()
        {
            ViewBag.IsCurrentMenu = "EMPLOYEE";
            EmployeeModels model = new EmployeeModels();
            ViewBag.DataList = GetGridData();
            ViewBag.MessageSuccess = GetUpdateMessage();
            return View(model);
        }

        public ActionResult Add()
        {
            EmployeeModels model = new EmployeeModels();
            model.flag_edit = 0;
            //  ViewBag.project_definition = dbUtil.GetProject(true);

            return View(model);
        }

        public ActionResult Edit(string id)
        {
            Session["SesHeaderId"] = id;
            Temployee data = db.Temployees.FirstOrDefault(a => a.Employeeid == id);
            if (data == null)
            {
                SetUpdateMessage("Data not found");
                return RedirectToAction("Index");
            }


            EmployeeModels model = new EmployeeModels()
            {
                flag_edit = 1,
                Employeeid =id,
                Fullname = data.Fullname,
                Birthdate = data.Birthdate,

            };


            return View(model);
        }


        //retun list data to gridview
        public ActionResult Grid()
        {
            ViewBag.DataList = GetGridData();
            return PartialView();
        }

        [HttpPost]
       //Insert or edit employee
        public ActionResult BtnSubmitAction(string employeeid, string fullname, string birthdate, int flag_edit)
        {
            string ReturnMessage = string.Empty;
            string sbirthdate = Regex.Replace(birthdate, " \\(.*\\)$", "");
            DateTime birth_date = DateTime.ParseExact(sbirthdate, "ddd MMM dd yyyy HH:mm:ss 'GMT'zzz",
            System.Globalization.CultureInfo.InvariantCulture);


            if (CheckIsValid(employeeid, fullname, birthdate, flag_edit))
            {
                using (var execTrans = new TransactionScope())
                {
                    try
                    {
                       

                        if (flag_edit == 1)
                        {
                            Temployee _getData = db.Temployees.FirstOrDefault(a => a.Employeeid ==employeeid);

                            _getData.Fullname = fullname;
                            _getData.Birthdate = birth_date;
                            db.SaveChanges();
                            SetUpdateMessage("<div class=\"alert alert-success\"><strong>Well done!</strong> You successfully to update Employee.</div>");

                        }
                        else
                        {

                           
                            string id = GetNewKode();
                           // int Employee_id = Convert.ToInt32(id);

                            Temployee _data = new Temployee()
                            {
                                Employeeid = id,
                                Fullname = fullname,
                                Birthdate = birth_date
                              

                            };
                            db.Temployees.Add(_data);
                            db.SaveChanges();
                            SetUpdateMessage("<div class=\"alert alert-success\"><strong>Well done!</strong> You successfully to create Employee.</div>");

                        }

                        ReturnMessage = "Success";
                        execTrans.Complete();
                    }
                    catch (Exception ex)
                    {
                        ReturnMessage = ex.Message.ToString();
                    }
                }
            }
            else
            {
                ViewBag.ErrorMessage = GetErrorMessage();
                ReturnMessage = ViewBag.ErrorMessage;
            }
            return Json(new { ReturnProcess = ReturnMessage, JsonRequestBehavior.AllowGet });
        }

        // function for delete record data
        [HttpPost]
        public ActionResult OnDeleteAction(string GetId)
        {
            string ReturnMessage = string.Empty;
            using (var execTrans = new TransactionScope())
            {
                try
                {
                    Temployee data = db.Temployees.FirstOrDefault(a => a.Employeeid ==GetId);
                    if (data == null)
                    {
                        SetUpdateMessage("Data not found");
                        return RedirectToAction("Index");
                    }
                    
                    Temployee _getData = db.Temployees.FirstOrDefault(a => a.Employeeid ==GetId);

                    db.Temployees.Remove(_getData);
                    db.SaveChanges();

                    ReturnMessage = "Success";
                    execTrans.Complete();
                }
                catch (Exception ex)
                {
                    ReturnMessage = ex.Message.ToString();
                }
            }
            return Json(new { ReturnProcess = ReturnMessage, JsonRequestBehavior.AllowGet });
        }



        //function pembuatan kode employee id baru
        public string GetNewKode()
        {

            string strKode = "";
           

                var query = from st in db.Temployees
                            orderby st.Employeeid descending
                            select st;
                var Employee = query.FirstOrDefault<Temployee>();
                if (Employee != null)
                {
                    strKode = Employee.Employeeid.ToString();
                    int NilaiMax = Convert.ToInt32(strKode) + 1;
                    strKode =NilaiMax.ToString();

                }
                else
                {
                    strKode = "1001";
                }

          
            return strKode;
        }

        //List Field data yg akan ditampilkan digrid
        public IEnumerable GetGridData()
        {
            var getData = (from a in db.Temployees
                           orderby a.Employeeid ascending
                           select new EmployeeModels
                           {
                               Employeeid = a.Employeeid,
                               Fullname = a.Fullname,
                               Birthdate=a.Birthdate

                           }  ).ToList();

            return getData;

        }


        //check validasidata field
        public bool CheckIsValid(string employeeid, string fullname, string birthdate, int flag_edit)
        {
            bool valid = true;
            string PopulateMessageError = string.Empty;
            string MessageError = string.Empty;

            if (string.IsNullOrWhiteSpace(fullname))
            {
                PopulateMessageError += "- Please Input Fullname. <br/>";
                valid = false;
            }

            
            if (PopulateMessageError != "")
            {
                SetErrorMessage(PopulateMessageError);
            }
            return valid;
        }
    }

}