﻿using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;
using System.Collections.Generic;

namespace Phonebook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //var contacts = new List<Contact>();
            return View(DataAccesscs.Constacts);
        }
    }
}
