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
        public bool updateStatusDisk(Disk disk)
        {
            var check = db.Disks.FirstOrDefault(x => x.idDisk.Equals(disk.idDisk));
            if(check != null)
            {
                check.status = disk.status;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Disk> getDisksOnShelf()
        {
            return db.Disks.Where(x => x.status == Entities.Enum.Status.OnShelf).ToList();
        }
    
        public Disk getDiskByID(string id)
        {
            return db.Disks.FirstOrDefault(x => x.idDisk == id);
        }
        public Disk GetONEDiskByIDtitle(string id)
        {
            return db.Disks.FirstOrDefault(x => x.idTitle == id);
        }
    }
}
