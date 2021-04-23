using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class Country
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Movie> Movies { get; set; }
        public virtual List<Actor> Actors { get; set; }
        public virtual List<Director> Directors { get; set; }

        /*
        public Country()
        {
            if(this.Actors == null)
            {
                this.Actors = new List<Actor>();
            }
        }
        */
    }
}
