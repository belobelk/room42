using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infrastructure.Interfaces;

namespace room42.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IRepository _repository;

        public BaseController(IRepository repository)
        {
            _repository = repository;
        }

    }
}
