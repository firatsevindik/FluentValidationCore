using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidationCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationCore.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {

            if (!ModelState.IsValid)
            { 
                // re-render the view when validation failed.
                return View("Create", person);
            }

            //Save the person to the database, or some other logic
            TempData["notice"] = "Person successfully created";
            return RedirectToAction("Create");

        }
    }
}