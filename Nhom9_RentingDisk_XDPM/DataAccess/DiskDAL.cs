using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DiskDAL
    {
        private RentingDiskDBContext db;
        public DiskDAL()
        {
            db = new RentingDiskDBContext();
        }
        public List<Disk> getDisks()
        {
            return db.Disks.ToList();
        }

        public List<Disk> GetListDiskByIDtitle(string id)
        {
            return db.Disks.Where(x => x.idTitle == id).ToList();
        }
    }
}
