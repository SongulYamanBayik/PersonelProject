using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class EducationController : Controller
    {
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        // GET: Education
        public ActionResult Index()
        {
            var values = PersonalDbEntities.TblEducation.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(TblEducation tbl)
        {
            var value = PersonalDbEntities.TblEducation.Add(tbl);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = PersonalDbEntities.TblEducation.Where(x => x.EducationID == id).FirstOrDefault();
            PersonalDbEntities.TblEducation.Remove(value);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditEducation(int id)
        {
            var values = PersonalDbEntities.TblEducation.Where(x => x.EducationID == id).FirstOrDefault();
            return View(values);
        }

        public ActionResult EditEducation(TblEducation t)
        {
            var value = PersonalDbEntities.TblEducation.Find(t.EducationID);
            value.EducationTitle = t.EducationTitle;
            value.EduationDate = t.EduationDate;
            value.EducationDescription = t.EducationDescription;
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}