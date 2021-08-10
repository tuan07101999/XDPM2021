using DataAccess;
using DataAccess.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DiskBLL
    {
        private DiskDAL dal;
        public DiskBLL()
        {
            dal = new DiskDAL();
        }
        public List<Disk> getDisks()
        {
            return dal.getDisks();
        }
        public List<Disk> GetListDiskByIDtitle(string id)
        {
            return dal.GetListDiskByIDtitle(id);
        }
        public bool updateStatusDisk(Disk disk)
        {
            return dal.updateStatusDisk(disk);
        }
        public List<Disk> getDisksOnShelf()
        {
            return dal.getDisksOnShelf();
        }
        public List<Disk> getDisksRented()
        {
            return dal.getDisksRented();
        }
        public Disk getDiskByID(string id)
        {
            return dal.getDiskByID(id);
        }
        public Disk GetONEDiskByIDtitle(string id)
        {
            return dal.GetONEDiskByIDtitle(id);
        }
        //Quoc
        public Disk GetONEDiskOnshelftByIDtitle(string id)
        {
            return dal.GetONEDiskOnshelftByIDtitle(id);
        }
        public Result delete(String idDisk)
        {
            return dal.delete(idDisk);
        }
        public Result addDisk(Disk disk)
        {
            return dal.addDisk(disk);
        }
    }
}
