using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterSheetApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(Models.Character.GetAll());
        }

        public ActionResult Create(String CharacterName)
        {
            Models.Character.Create(CharacterName);
            var model = new CharacterSheetApp.Models.Character();
            model.Name =CharacterName;
            //model.Create(characterName);
            return RedirectToAction("Index");
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
    }
}