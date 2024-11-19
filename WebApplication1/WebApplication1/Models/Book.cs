﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Book
    {
        [Required]

        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public int PublishedYear { get; set; }


    }
}
