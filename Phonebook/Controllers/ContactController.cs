using System;
using Phonebook.Controllers;
using Phonebook.Data.Models;
using Phonebook.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Drawing;
using System.Data;
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
        public FileStreamResult GetFile()
        {
            string name = string.Empty;
            if (DataAccesscs.Constacts.Count>1)
            {
                name = "contacts";
            }
            else if (DataAccesscs.Constacts.Count == 1)
            {
                name = "contact";
            }
            else
            {
                name = "NoConatcts";
                //TO DO: Empty File 
            }
            FileInfo info = new FileInfo(name);
                using (StreamWriter writer = info.CreateText())
                {
                    foreach (var person in DataAccesscs.Constacts)
                    {
                        writer.WriteLine(person.Name + " - " + person.Number);
                    }
                }
            return File(info.OpenRead(),"txt/txt",string.Format("{0}.txt",name));
        }
    }
}