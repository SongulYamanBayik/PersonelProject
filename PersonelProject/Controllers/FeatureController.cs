using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class FeatureController : Controller
    {
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        // GET: Feature
        public ActionResult Index()
        {
            var value = PersonalDbEntities.TblFeature.ToList();

            return View(value);
        }
        [HttpGet]
        public ActionResult AddFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFeature(TblFeature f)
        {
            PersonalDbEntities.TblFeature.Add(f);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
            var values=PersonalDbEntities.TblFeature.Where(x => x.FeatureID == id).FirstOrDefault();
            PersonalDbEntities.TblFeature.Remove(values);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditFeature(int id)
        {
            var value = PersonalDbEntities.TblFeature.Where(x => x.FeatureID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public ActionResult EditFeature(TblFeature t)
        {
            var values = PersonalDbEntities.TblFeature.Find(t.FeatureID);
            values.FeatureTitle = t.FeatureTitle;
            values.FeatureLogo = t.FeatureLogo;
            values.FeatureDescription = t.FeatureDescription;
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}