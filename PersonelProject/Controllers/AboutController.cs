using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class AboutController : Controller
    {
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AboutMe()
        {
            return PartialView();
        }

        public PartialViewResult Welcome()
        {
            return PartialView();
        }

        public PartialViewResult Statistics()
        {

            ViewBag.v1 = PersonalDbEntities.TblSkill.Count();
            ViewBag.v2 = PersonalDbEntities.TblImage.Where(x => x.Category == "C#").Count();
            ViewBag.v3 = PersonalDbEntities.TblExperience.OrderByDescending(x => x.ExperienceID).FirstOrDefault().ExperienceDescription;
            ViewBag.v4 = PersonalDbEntities.TblEducation.Where(x => x.EducationID == 1).FirstOrDefault().EducationDescription;
            return PartialView();
        }

        public PartialViewResult Subscribe()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public PartialViewResult Script()
        {
            return PartialView();
        }
    }
}