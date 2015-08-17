using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPacs.Models
{
    public class Patient
    {
        public virtual string PatientID { get; set; }
        public virtual string Name { get; set; }
        public virtual string OtherName { get; set; }
        public virtual string Sex { get; set; }
        public virtual string Birthday { get; set; }
        public virtual string BloodType { get; set; }
        public virtual string Country { get; set; }
        public virtual string IDCard { get; set; }
        public virtual string Address { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string TelNo { get; set; }
        public virtual string Comment { get; set; }

    }
}