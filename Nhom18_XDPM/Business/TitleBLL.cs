using Business.Models;
using DataAccess;
using DataAccess.DTO;
using DataAccess.Entities;
using DataAccess.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TitleBLL
    {
        private TitleDAL dal;
        private DiskBLL diskBLL;
        private HoldingBLL holdingBLL;
        public TitleBLL()
        {
            diskBLL = new DiskBLL();
            holdingBLL = new HoldingBLL();
            dal = new TitleDAL();
        }
        public Title GetItemTitleById(string id)
        {
            return dal.GetItemTitleById(id);
        }
        public List<Title> GetListTitleByID(string id)
        {
            return dal.GetListTitleByID(id);
        }
        public Result addTitle(Title title)
        {
            return dal.addTitle(title);
        }
        public Title GetTitleByName(string namett)
        {
            return dal.GetItemTitleById(namett);
        }
        public int getIdCategoryByIdTitle(string idTitle)
        {
            return dal.getIdCategoryByIdTitle(idTitle);
        }
        public List<Title> GetAlltt()
        {
            return dal.GetAllTitle().ToList();
        }
        //public Disk GetDiskById(string id)
        //{
        //    return dal.getDisks().FirstOrDefault(disk => disk.idDisk == id);
        //}
        //public Disk GetONEDiskByIDtitle(string id)
        //{
        //    return dal.GetONEDiskByIDtitle(id);
        //}
        public List<TitleReportModel> GetTitleReport()
        {
            var allTitle = dal.GetAllTitle();
            var allDisk = diskBLL.getDisks();
            var allHodings = holdingBLL.GetAllHoding();

            var result = allTitle.Select(title => new TitleReportModel
            {
                TieuDe = title.name,
                TongSoBanSaoDangDuocThue = allDisk.Where(d => d.idTitle == title.idTitle && d.status == Status.Rented).Count(),
                SoLuongBanSaoDangDat = allHodings.Where(hd => hd.idTitle == title.idTitle).Count(),
                TongSoBanSao = allDisk.Where(d => d.idTitle == title.idTitle).Count(),
            }).ToList();

            return result;
        }
    }
}
