using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    public class ActorMovie
    {
        public int ActorId { get; set; }
        //[ForeignKey(nameof(ActorId))]
        public virtual Actor Actor { get; set; }

        public int MovieId { get; set; }
        //[ForeignKey(nameof(MovieId))]
        public virtual Movie Movie { get; set; }
    }
}
