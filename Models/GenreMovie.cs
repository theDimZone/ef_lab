using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class GenreMovie
    {
        public int GenreId { get; set; }
        //[ForeignKey(nameof(GenreId))]
        public virtual Genre Genre { get; set; }

        public int MovieId { get; set; }
        //[ForeignKey(nameof(MovieId))]
        public virtual Movie Movie { get; set; }
    }
}
