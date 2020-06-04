using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework6_CSHP_220.Models;
using Microsoft.AspNetCore.Mvc;


namespace Homework6_CSHP_220.Controllers
{
    public class HomeController : Controller
{
        
    public IActionResult Index()
    {
        return View();
    }

        [HttpPost]
        public IActionResult Index(SignerResponse signerResponse)
        {
            if (ModelState.IsValid)
            {
                return View("CardSentForm", signerResponse);
            }

            return View();
        }

    }
}
