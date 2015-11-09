using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mywebsite.Repository;
using mywebsite.ViewModels.Home;

namespace mywebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new CarouselRepository();
            var model = new IndexViewModel()
            {
                CarouselResources = repo.GetAll().Take(3).OrderBy(r => r.Ordinal)
            };

            return View(model);
        }
    }
}