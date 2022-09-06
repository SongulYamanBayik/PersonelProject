using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProject.Models;

namespace PersonelProject.Controllers
{
    public class TestimonialController : Controller
    {
        PersonalDbEntities PersonalDbEntities = new PersonalDbEntities();
        // GET: Testimonial
        public ActionResult Index()
        {
            var values = PersonalDbEntities.TblTestimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(TblTestimonial b)
        {
            PersonalDbEntities.TblTestimonial.Add(b);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = PersonalDbEntities.TblTestimonial.Where(x => x.TestimonialID == id).FirstOrDefault();
            PersonalDbEntities.TblTestimonial.Remove(value);
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditTestimonial(int id)
        {
            var value = PersonalDbEntities.TblTestimonial.Where(x => x.TestimonialID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public ActionResult EditTestimonial(TblTestimonial l)
        {
            var value = PersonalDbEntities.TblTestimonial.Find(l.TestimonialID);
            value.TestimonialName = l.TestimonialName;
            value.TestimonialImage = l.TestimonialImage;
            value.TestimonialTitle = l.TestimonialTitle;
            value.TestimonialDescription = l.TestimonialDescription;
            PersonalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}