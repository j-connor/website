using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mywebsite.ViewModels.About;
using mywebsite.Repository;

namespace mywebsite.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
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