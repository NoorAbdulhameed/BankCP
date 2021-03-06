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
        [Required(ErrorMessageResourceName = "errorEnName", ErrorMessageResourceType = typeof(GlobalResource.Resources.LangText))]
        [Display(Name = "enName", ResourceType = typeof(GlobalResource.Resources.LangText))]
        [MaxLength(100, ErrorMessageResourceName = "errorMax", ErrorMessageResourceType = typeof(GlobalResource.Resources.LangText))]
        public string enName { get; set; }
        [Required(ErrorMessageResourceName = "errorArName", ErrorMessageResourceType = typeof(GlobalResource.Resources.LangText))]
        [Display(Name = "arName", ResourceType = typeof(GlobalResource.Resources.LangText))]
        [MaxLength(100, ErrorMessageResourceName = "errorMax", ErrorMessageResourceType = typeof(GlobalResource.Resources.LangText))]
        public string arName { get; set; }
        public bool active { get; set; }
        public int bankId { get; set; }
    }
}
