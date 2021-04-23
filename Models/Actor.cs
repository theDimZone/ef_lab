using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class Actor
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public virtual List<ActorMovie> ActorMovies { get; set; }

        public int? CountryId { get; set; }

        //[ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }

    }
}
