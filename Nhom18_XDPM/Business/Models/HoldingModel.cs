using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class HoldingModel
    {
        public int idHolding { get; set; }
        public string titleName { get; set; }
        public string customerName { get; set; }
        public int idCustomer { get; set; }
        public string idTitle { get; set; }

        public DateTime reservationTime { get; set; }

    }
}
