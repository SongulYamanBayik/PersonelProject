using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class DefaultController : Controller
    {
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
           
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult BannerPartial()
        {
            return PartialView();
        }

        public PartialViewResult SkillPartial()
        {
            var values = PersonalDbEntities.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult FeaturePartial()
        {
            return PartialView();
        }

        public PartialViewResult ImagePartial()
        {
            ViewBag.v = "proje görsellerimi buradan görebilirsiniz.";
            //ViewBag.a1 = PersonalDbEntities.TblImage.Where(x => x.Category == "C#").;
            var value = PersonalDbEntities.TblImage.ToList();
            return PartialView(value);
        }


        public PartialViewResult ExperincePartial()
        {
            
            return PartialView();
        }

        public PartialViewResult EducationPartial()
        {

            return PartialView();
        }

        public PartialViewResult TestimonalPartial()
        {

            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {

            return PartialView();
        }

        public PartialViewResult scriptPartial()
        {

            return PartialView();
        }
    }
}