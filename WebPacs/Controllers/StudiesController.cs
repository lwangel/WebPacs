using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPacs.Models;

namespace WebPacs.Controllers
{
    public class StudiesController : Controller
    {
        private WebPacsEntities db = new WebPacsEntities();

        // GET: Studies
        public ActionResult Index()
        {
            return View(db.Studys.ToList());
        }

        // GET: Studies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Study study = db.Studys.Find(id);
            string strPatientID=study.PatientID.ToString();
            Patient patient = db.Patients.Find(strPatientID);
            ViewBag.PatientName = patient.Name.ToString();
            ViewBag.Sex = patient.Sex.ToString();
            if (study == null)
            {
                return HttpNotFound();
            }
            return View(study);
        }

        // GET: Studies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studies/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudyID,PatientID,Modality,BodyPartExamined,LogonDate,Registrar,StudyDate,Operator,ReportDate,NameOfPhysiciansReadingStudy,AssessDate,Assessor,ExamReport,Conclusion,Status,ReportPrintStatus,FilmPrintStatus,ReportPrintDate,FilmPrintDate")] Study study)
        {
            if (ModelState.IsValid)
            {
                db.Studys.Add(study);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(study);
        }

        // GET: Studies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Study study = db.Studys.Find(id);
            if (study == null)
            {
                return HttpNotFound();
            }
            return View(study);
        }

        // POST: Studies/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudyID,PatientID,Modality,BodyPartExamined,LogonDate,Registrar,StudyDate,Operator,ReportDate,NameOfPhysiciansReadingStudy,AssessDate,Assessor,ExamReport,Conclusion,Status,ReportPrintStatus,FilmPrintStatus,ReportPrintDate,FilmPrintDate")] Study study)
        {
            if (ModelState.IsValid)
            {
                db.Entry(study).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(study);
        }

        // GET: Studies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Study study = db.Studys.Find(id);
            if (study == null)
            {
                return HttpNotFound();
            }
            return View(study);
        }

        // POST: Studies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Study study = db.Studys.Find(id);
            db.Studys.Remove(study);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
