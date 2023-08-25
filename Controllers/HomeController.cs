using System.Collections.Generic;
using System.Diagnostics;
using CommentPage.Models;
using Microsoft.AspNetCore.Mvc;
using CommentPage.Models;
using CommentPage.Repository;

namespace CommentPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: PersonalDataController

        minitwitterRepository ObjRepository;

        public HomeController()
        {
            ObjRepository = new minitwitterRepository();
        }

        public IActionResult Index()
        {
            return View();
        }


        public ActionResult List()
        {
            return View("List", ObjRepository.Selectcommand());
        }


        // GET: PersonalDataController/Create
        public ActionResult Insert()
        {
            return View("Insert", new minitwitterDataModel());
        }

        // POST: PersonalDataController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(minitwitterDataModel data)
        {
            try
            {
                ObjRepository.Insertcommand(data);
                return RedirectToAction(nameof(Insert));
            }
            catch
            {
                return View();
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}