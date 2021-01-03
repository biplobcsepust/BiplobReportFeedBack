using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReportFeedBack.Controllers
{
    public class PostedUnseInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}