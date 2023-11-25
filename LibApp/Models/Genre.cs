﻿using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}
