using DataAccess;
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
    }
}
