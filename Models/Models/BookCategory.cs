﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Entities.Models
{
    public class BookCategory
    {
        [Key]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "Category can not be blank")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Favorite { get; set; }
    }
}
