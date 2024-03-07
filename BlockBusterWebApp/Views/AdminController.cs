using BlockBuster;
using BlockBuster.Models;
using BlockBusterWebApp.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace BlockBusterWebApp.Views
{
    public class AdminController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            var movie = BlockBusterBasicFunctions.GetMovieByID(id);
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {

            ViewBag.GenreID = DeepDownFormatter.FormatGenres();
            ViewBag.DirectorId = DeepDownFormatter.FormatDirectors();
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movieToCreate)
        {
            try
            {
                return RedirectToAction("Movies","Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = BlockBusterBasicFunctions.GetMovieByID(id);
            ViewBag.GenreID = DeepDownFormatter.FormatGenres();
            ViewBag.DirectorId = DeepDownFormatter.FormatDirectors();
            return View(movie);
        }


        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movieToEdit)
        {
            try
            {
                BlockBusterAdminFunctions.EditMovie(movieToEdit);
                return RedirectToAction("Movies","Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = BlockBusterBasicFunctions.GetMovieByID(id);
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
