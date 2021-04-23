using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class Media
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; } // url / youtube / img

        [Required]
        public string Url { get; set; }

        public int MovieId { get; set; }
        //[ForeignKey(nameof(MovieId))]
        public virtual Movie Movie { get; set; }
    }
}
