﻿using System.ComponentModel.DataAnnotations;

namespace bookstore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author{ get; set; }

        public string ISBN { get; set; }  

    }
}
