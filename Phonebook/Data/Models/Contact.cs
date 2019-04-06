﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }

    }
}
