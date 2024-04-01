using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcGridTransaction.Models
{
    public class EmployeeModels
    {
        public string Employeeid { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthdate { get; set; }
        public int flag_edit { get; set; }


    }
}