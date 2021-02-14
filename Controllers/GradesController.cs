using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200.DALSDTWO;
using MIS4200.Models;

namespace MIS4200.Controllers
{
    public class GradesController : Controller
    {
        private MIS4200ContextSD2 db = new MIS4200ContextSD2();

        // GET: Grades
        public ActionResult Index()
        {
            var grade = db.grade.Include(g => g.student);
            return View(grade.ToList());
        }

        // GET: Grades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.grade.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            return View(grade);
        }

        // GET: Grades/Create
        public ActionResult Create()
        {
            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName", "lastName");
            return View();
        }

        // POST: Grades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gradeID,courseID,letterGrade,studentID")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                db.grade.Add(grade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName", grade.studentID);
            return View(grade);
        }

        // GET: Grades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.grade.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName", grade.studentID);
            return View(grade);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "gradeID,courseID,letterGrade,studentID")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName", grade.studentID);
            return View(grade);
        }

        // GET: Grades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.grade.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            return View(grade);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grade grade = db.grade.Find(id);
            db.grade.Remove(grade);
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
