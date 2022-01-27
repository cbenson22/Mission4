﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3.Models
{
    public class ApplicationResponse
    {

        [Required]
        public string Category { get; set; }
        [Key]
        [Required]
        public string MovieName { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]

        public string Director { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        public string Notes { get; set; }
    }
}
