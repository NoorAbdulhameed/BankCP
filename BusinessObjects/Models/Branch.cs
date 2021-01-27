﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Branch
    {
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string enName { get; set; }
        [Required]
        [MaxLength(100)]
        public string arName { get; set; }
        public bool active { get; set; }
        public int bankId { get; set; }
    }
}