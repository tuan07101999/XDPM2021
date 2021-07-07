using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class RecordDTO
    {
        public int idRecord { get; set; }
        public string nameCustomer { get; set; }
        public string nameDisk { get; set; }
        public DateTime? rentDate { get; set; }
        public DateTime? dueDate { get; set; }
        public DateTime? actualReturnDate { get; set; }
        public float lateFee { get; set; }
        public bool isPaid { get; set; }
    }
}
