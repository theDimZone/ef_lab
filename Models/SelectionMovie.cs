using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class SelectionMovie
    {
        public int SelectionId { get; set; }
        //[ForeignKey(nameof(SelectionId))]
        public virtual Selection Selection { get; set; }

        public int MovieId { get; set; }
        //[ForeignKey(nameof(MovieId))]
        public virtual Movie Movie { get; set; }
    }
}
