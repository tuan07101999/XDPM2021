using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Holding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idHolding { get; set; }
        public int idCustomer { get; set; }
        public string idTitle { get; set; }
        public DateTime reservationTime { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Title Title { get; set; }


    }
}
