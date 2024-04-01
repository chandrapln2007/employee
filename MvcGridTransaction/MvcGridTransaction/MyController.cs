using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGridTransaction.Models;

namespace MvcGridTransaction
{
    public class MyController : Controller
    {

        protected MvcGrid_Entities db;
       protected DbUtilityService dbUtil;

        public MyController()
            : base()
        {
            db = new MvcGrid_Entities();
           dbUtil = new DbUtilityService(db);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        protected string GetUpdateMessage()
        {
            string updateMessage = (string)Session["UpdateMessage"];
            if (updateMessage == null)
                updateMessage = "";
            Session["UpdateMessage"] = "";
            return updateMessage;
        }

        protected void SetUpdateMessage(string s)
        {
            Session["UpdateMessage"] = s;
        }

        protected string GetSuccessMessage()
        {
            string updateMessage = (string)Session["SuccessMessage"];
            if (updateMessage == null)
                updateMessage = "";
            Session["SuccessMessage"] = "";
            return updateMessage;
        }

        protected void SetSuccessMessage(string s)
        {
            Session["SuccessMessage"] = s;
        }

        protected string GetErrorMessage()
        {
            string updateMessage = (string)Session["ErrorMessage"];
            if (updateMessage == null)
                updateMessage = "";
            Session["ErrorMessage"] = "";
            return updateMessage;
        }

        protected void SetErrorMessage(string s)
        {
            Session["ErrorMessage"] = s;
        }

        protected string GetCurrentKey()
        {
            string result = (string)Session["CurrentKey"];
            if (result == null)
                result = "";
            Session["CurrentKey"] = null;
            return result;
        }

        protected void SetCurrentKey(string s)
        {
            Session["CurrentKey"] = s;
        }

    }
}

 public partial class DbUtilityService
    {
     private MvcGrid_Entities db = null;

     public DbUtilityService(MvcGrid_Entities db)
        {
            this.db = db;
        }
}

