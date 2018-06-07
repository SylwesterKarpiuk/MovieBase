using MovieBase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieBase.Controllers
{
    public class HomeController : Controller
    {
        MovieDbContext db = new MovieDbContext();

        public ActionResult Index()
        {
            using (MovieDbContext db = new MovieDbContext())
            {
                return View(db.MovieDb.ToList());
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddMovie(MovieDb movie, HttpPostedFileBase file)
        { 
            if (file != null)
            {
                file.SaveAs(HttpContext.Server.MapPath("~/Content/Images/")
                                                      + file.FileName);
                movie.PictureLink = file.FileName;
            }
            movie.Added = DateTime.Now.ToString();
            db.MovieDb.Add(movie);
            try
            {
                db.SaveChanges();
                RedirectToAction("Index");
            }
            catch (DbEntityValidationException ex)
            {

            }
            return View();
        }
    }
}