using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Title
    {
        [Key]
        [RegularExpression(@"^\d{3}$")]
        public string idTitle { get; set; }
        public string name { get; set; }
        public int numberOfCopies { get; set; }

        public int idCategory { get; set; }
        public virtual Category Category { get; set; }

        public virtual IEnumerable<Disk> Disks { get; set; }
        public virtual IEnumerable<Holding> Holdings { get; set; }

    }
}
