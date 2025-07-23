﻿using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name...")]
        public string Name { get; set; } = string.Empty;
    }
}
