using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Display(Name = "Review")]
        [Required(ErrorMessage = "Review cannot be left blank.")]
        public string Comment { get; set; }

        [Display(Name = "Reviewer")]
        [Required(ErrorMessage = "You must enter your name.")]
        public string Reviewer { get; set; }

        [Display(Name = "Movie Title")]
        [Required(ErrorMessage = "You must include a movie title.")]
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }
}
