﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My_Project.Models
{
    public class Message : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        public string MessageSide { get; set; }
        public DateTime Date { get; set; }
    }
}
