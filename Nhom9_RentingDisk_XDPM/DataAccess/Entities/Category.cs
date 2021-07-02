using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCategory { get; set; }
        public string name { get; set; }
        public int rentalPeriod { get; set; }
        public float rentalCharge { get; set; }
        public float lateFee { get; set; }

        public virtual IEnumerable<Title> Titles { get; set; }

    }
}
