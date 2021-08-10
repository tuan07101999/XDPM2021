using DataAccess.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public List<Disk> getDisksRented()
        {
            return db.Disks.Where(x => x.status == Entities.Enum.Status.Rented).ToList();
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

        //Quoc
        public Disk GetONEDiskOnshelftByIDtitle(string id)
        {
            return db.Disks.FirstOrDefault(x => x.idTitle == id && x.status == Entities.Enum.Status.OnShelf);
        }

        public Result addDisk(Disk disk)
        {
            var Tempdisk = db.Disks.FirstOrDefault(x => x.idDisk == disk.idDisk);
            if(Tempdisk != null)
            {
                return new Result
                {
                    message = "Trùng mã không thể thêm",
                    isSuccess = false
                };
            }    
            db.Disks.Add(disk);
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                return new Result
                {
                    message = e
                        .EntityValidationErrors
                        .LastOrDefault()
                        .ValidationErrors
                        .LastOrDefault()
                        .ErrorMessage,
                    isSuccess = false
                };
            }
            return new Result
            {
                message = "Thêm thành công",
                isSuccess = true
            };
        }


        public Result delete(String idDisk)
        {
            var item = db.Disks.FirstOrDefault(x => x.idDisk == idDisk);

            if (item != null)
            {
                db.Disks.Remove(item);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    return new Result
                    {
                        message = e
                            .EntityValidationErrors
                            .LastOrDefault()
                            .ValidationErrors
                            .LastOrDefault()
                            .ErrorMessage,
                        isSuccess = false
                    };
                }
                return new Result
                {
                    message = "Xóa đĩa thành công",
                    isSuccess = true
                };
            }
            else
            {
                return new Result
                {
                    message = "Đĩa không tìm thấy",
                    isSuccess = false
                };
            }
        }
    }
}
