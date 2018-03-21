using NinjectTestBlog.TestFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectTestBlog.Controllers
{
    public class NumbersController : Controller
    {
        private readonly INumberRepository numbersRepo;

        public NumbersController(INumberRepository repo)
        {
            numbersRepo = repo;
        }

        // GET: Numbers
        public ActionResult Index()
        {
            IList<int> numbers = numbersRepo.GetNumbers();
            return View(numbers);
        }
    }
}