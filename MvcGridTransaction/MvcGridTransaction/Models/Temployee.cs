using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcGridTransaction.Models
{
     [Table("Memployee")]
    public class Temployee
    {
        [Key]
        public string Employeeid { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthdate { get; set; }
      

    }
}