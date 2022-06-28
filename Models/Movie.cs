using System;
using System.ComponentModel.DataAnnotations;

namespace Mayvue_Tech_Test.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Movie Title")]
        public string Name { get; set; }

        [StringLength(500, MinimumLength = 3)]
        [Display(Name = "Movie Synopsis")]
        public string Description { get; set; }

        [Required]
        [Range(1888, 2050)]
        [Display(Name = "Release Year")]
        public int Year { get; set; }
    }
}