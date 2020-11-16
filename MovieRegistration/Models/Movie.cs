using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        [Required]
        public int ID { get; set; }

        [MaxLength(50,ErrorMessage = "Movie title can not be longer that 50 characters.")]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }

        public List<string> Genre { get; set; }

        public Movie(int iD, string title, int year, string actors, string directors, List<string> genre)
        {
            ID = iD;
            Title = title;
            Year = year;
            Actors = actors;
            Directors = directors;
            Genre = genre;
        }
    }
}
