using System;
using Phonebook.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data
{
    public class DataAccesscs
    {
        public static List<Contact> Constacts { get; set; } = new List<Contact>();
    }
}
