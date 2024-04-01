using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace MvcGridTransaction.Models
{

    public class MvcGrid_Entities : DbContext
    {
        #region TABLES
        public DbSet<Temployee> Temployees { get; set; }
      
             
       
        #endregion

     






        public MvcGrid_Entities()
            : base("Name=MvcGrid")
        {
        }
    }
}