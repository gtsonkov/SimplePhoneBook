using System;
using Phonebook.Controllers;
using Phonebook.Data.Models;
using Phonebook.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Create(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Name and Phone number are required!";
            }
            else
            {
                DataAccesscs.Constacts.Add(contact);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}