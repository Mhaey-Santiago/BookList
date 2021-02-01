﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookList.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }
    }
}
