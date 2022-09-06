using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class ImageController : Controller
    {
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        // GET: Image
        public ActionResult Index()
        {
            var value = PersonalDbEntities.TblImage.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddImage(TblImage t)
        {
            var value = PersonalDbEntities.TblImage.Add(t);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteImage(int id)
        {
            var value = PersonalDbEntities.TblImage.Where(x => x.ImageID == id).FirstOrDefault();
            PersonalDbEntities.TblImage.Remove(value);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditImage(int id)
        {
            var value = PersonalDbEntities.TblImage.Where(x => x.ImageID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public ActionResult EditImage(TblImage t)
        {
            var values = PersonalDbEntities.TblImage.Find(t.ImageID);
            values.ImageUrl = t.ImageUrl;
            values.ImageDescription = t.ImageDescription;
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}