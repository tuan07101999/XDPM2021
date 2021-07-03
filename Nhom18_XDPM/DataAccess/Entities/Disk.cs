using DataAccess.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Disk
    {
        [Key]
        [RegularExpression(@"^\d{6}$")]
        public string idDisk { get; set; }
        public string name { get; set; }

        public Status status { get; set; }

        public string idTitle { get; set; }
        public virtual Title Title { get; set; }

        public virtual IEnumerable<Record> Records { get; set; }
    }
}
