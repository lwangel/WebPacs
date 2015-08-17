using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPacs.Models
{
    public class Study
    {
        public virtual int StudyID { get; set; }
        public virtual string PatientID { get; set; }
        public virtual string Modality { get; set; }
        public virtual string BodyPartExamined { get; set; }
        public virtual string LogonDate { get; set; }
        public virtual string Registrar { get; set; }
        public virtual string StudyDate { get; set; }
        public virtual string Operator { get; set; }
        public virtual string ReportDate { get; set; }
        public virtual string NameOfPhysiciansReadingStudy { get; set; }
        public virtual string AssessDate { get; set; }
        public virtual string Assessor { get; set; }
        public virtual string ExamReport { get; set; }
        public virtual string Conclusion { get; set; }
        public virtual string Status { get; set; }
        public virtual string ReportPrintStatus { get; set; }
        public virtual string FilmPrintStatus { get; set; }
        public virtual string ReportPrintDate { get; set; }
        public virtual string FilmPrintDate { get; set; }
    }
}