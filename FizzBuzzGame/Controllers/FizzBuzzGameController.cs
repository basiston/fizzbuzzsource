using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzGame.Controllers
{
    public class FizzBuzzGameController : Controller
    {
        // GET: FizzBuzzGame
        public ActionResult Index()
        {
            return View();
        }
    }
}