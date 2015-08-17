using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebPacs.Models
{
    public class WebPacsEntities:DbContext
    {
        public WebPacsEntities() : base("WebPacsEntities") 
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Study> Studys { get; set; }
    }
}