using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class CustomerReportModel
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public int SoDiaThue { get; set; }
        public int SoDiaQuaHan { get; set; }
        public double LateFee { get; set; }
    }
}
