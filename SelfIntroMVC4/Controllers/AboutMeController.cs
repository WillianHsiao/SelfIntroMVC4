using SelfIntroMVC4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfIntroMVC4.Controllers
{
    public class AboutMeController : Controller
    {
        // GET: AboutMe
        public ActionResult Index()
        {
            var model = new AboutMeModel();
            model.Name = "蕭瑋彥";
            model.NickName = "小白";
            model.EnglishName = "Willian";
            model.BirthDay = DateTime.Parse("1986/12/01");
            return View(model);
        }
    }
}