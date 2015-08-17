using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPacs.Models;

namespace WebPacs.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            ViewBag.Title = "PACS BS版本 V0.1 beta";
            var study = new List<Study> { 
            new Study{StudyID = 1, Modality = "DX", BodyPartExamined = "胸部正位"},
            new Study{StudyID = 2, Modality = "CT", BodyPartExamined = "头颅正侧位"},
            new Study{StudyID = 3, Modality = "MR", BodyPartExamined = "颈椎正侧位"}
            };
            return View(study);
        }

        public ActionResult Browse(string name)
        {
            var patient = new Patient { Name =  name };
            return View(patient);
        }
    }
}