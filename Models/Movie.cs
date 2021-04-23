using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Details { get; set; }
        public int Year { get; set; }   

        public virtual List<GenreMovie> GenreMovies { get; set; }
        public virtual List<ActorMovie> ActorMovies { get; set; } //= new List<ActorMovie>();
        public virtual List<SelectionMovie> SelectionMovies { get; set; }
        public virtual List<Media> Media { get; set; }

        public int? DirectorId { get; set; }
        //[ForeignKey(nameof(DirectorId))]
        public virtual Director Director { get; set; }

        public int? CountryId { get; set; }
        //[ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }
    }
}
