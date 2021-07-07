using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class HasOverdueModel
    {
        public string TieuDe { get; set; }
        public DateTime NgayDenHan { get; set; }
        public DateTime NgayTra { get; set; }
        public double SoTien { get; set; }
    }
}
