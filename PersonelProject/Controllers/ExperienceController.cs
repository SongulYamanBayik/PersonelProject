using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class ExperienceController : Controller
    {
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        public ActionResult Index()
        {
            var values = PersonalDbEntities.TblExperience.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(TblExperience e)
        {
            PersonalDbEntities.TblExperience.Add(e);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

       public ActionResult DelExperience(int id)
        {
            var value = PersonalDbEntities.TblExperience.Where(x => x.ExperienceID == id).FirstOrDefault();
            PersonalDbEntities.TblExperience.Remove(value);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditExperience(int id)
        {
            var values = PersonalDbEntities.TblExperience.Where(x => x.ExperienceID == id).FirstOrDefault();
            // var values1 = PersonalDbEntities.TblExperience.Find(id);

            return View(values);

        }
        [HttpPost]
        public ActionResult EditExperience(TblExperience t)
        {
            var values = PersonalDbEntities.TblExperience.Find(t.ExperienceID);

            values.ExperienceTitle = t.ExperienceTitle;
            values.ExperienceDate = t.ExperienceDate;
            values.ExperienceDescription = t.ExperienceDescription;
            PersonalDbEntities.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}