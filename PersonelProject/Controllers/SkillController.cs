using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        public ActionResult Index()
        {
            var values = PersonalDbEntities.TblSkill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
       [HttpPost]
        public ActionResult AddSkill(TblSkill p)
        {
            PersonalDbEntities.TblSkill.Add(p);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = PersonalDbEntities.TblSkill.Where(x => x.SkillID == id).FirstOrDefault();
            PersonalDbEntities.TblSkill.Remove(value);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var value = PersonalDbEntities.TblSkill.Where(x => x.SkillID == id).FirstOrDefault();
            return View(value);
        }


        [HttpPost]
        public ActionResult EditSkill(TblSkill s)
        {
            var value = PersonalDbEntities.TblSkill.Find(s.SkillID);
            value.SkillTitle = s.SkillTitle;
            value.SkillValue = s.SkillValue;
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}