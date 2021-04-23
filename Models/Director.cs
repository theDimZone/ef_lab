using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class Director
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        public virtual List<Movie> Movies { get; set; }

        public int? CountryId { get; set; }
        //[ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }
    }
}
