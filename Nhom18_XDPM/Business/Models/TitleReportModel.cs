using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class TitleReportModel
    {
        public string TieuDe { get; set; }
        public int TongSoBanSao { get; set; }
        public int TongSoBanSaoDangDuocThue { get; set; }
        public int TongSoBanSaoTrongKho { 
            get { return TongSoBanSao - TongSoBanSaoDangDuocThue; }
            set { TongSoBanSaoTrongKho = value; }
        }
        public int SoLuongBanSaoDangDat { get; set; }
    }
}
