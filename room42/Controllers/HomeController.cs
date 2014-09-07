using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Models;
using Infrastructure.Interfaces;

namespace room42.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IRepository repository) : base(repository)
        {}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders()
        {
            var orders = _repository.All<Order>();
            return PartialView(orders.ToList());
        }
    }
}
