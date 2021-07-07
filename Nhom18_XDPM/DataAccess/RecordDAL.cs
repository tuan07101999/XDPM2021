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
    public class RecordDAL
    {
        private RentingDiskDBContext db;
        public RecordDAL()
        {
            db = new RentingDiskDBContext();
        }
        public List<Record> GetAllRecord()
        {
            return db.Records.ToList();
        }

        public Record GetDiskById(string id)
        {
            return db.Records.FirstOrDefault(x => x.idDisk == id && x.actualReturnDate == null) ;
        }
        public List<Record> GetAllRecordUnPaid(int id)
        {
            return db.Records.Where(x=>x.isPaid == false && x.idCustomer==id && x.actualReturnDate != null).ToList();
        }
        public List<Record> GetAllRecordUnReturn(int id)
        {
            return db.Records.Where(x =>x.actualReturnDate==null&&x.idCustomer == id).ToList();
        }
        public Result UpdateDateReturnAndLateFee(Record record)
        {
            var item = db.Records.FirstOrDefault(x => x.idCustomer.Equals(record.idCustomer)
                                                   && x.idDisk.Equals(record.idDisk)
                                                   //&& x.idTitle.Equals(record.idTitle)
                                                    );
            if (item != null)
            {
                item.actualReturnDate = record.actualReturnDate;
                if(item.actualReturnDate > item.dueDate)
                {
                    item.lateFee = 1;
                }
                else
                {
                    item.lateFee = 0;
                }
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
                    message = "Cập nhật thành công",
                    isSuccess = true
                };
            }
            else
            {
                return new Result
                {
                    message = "Đơn hàng không tồn tại",
                    isSuccess = false
                };
            }
        }
        public Result UpdateIsPaid(Record record)
        {
            var item = db.Records.FirstOrDefault(x => x.idCustomer.Equals(record.idCustomer)
                                                   && x.idDisk.Equals(record.idDisk)
                                                    );
            if (item != null)
            {
                item.isPaid = true;
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
                    message = "Cập nhật thành công",
                    isSuccess = true
                };
            }
            else
            {
                return new Result
                {
                    message = "Đơn hàng không tồn tại",
                    isSuccess = false
                };
            }
        }
        public List<Record> checkLateFee(int idCustomer)
        {
            return db.Records.Where(x => x.idCustomer == idCustomer && x.actualReturnDate > x.dueDate && !x.isPaid).ToList();
        }
        public Record getRecordByID(int id)
        {
            return db.Records.FirstOrDefault(x => x.idRecord == id);
        }
        public bool addRecord(Record record)
        {
            db.Records.Add(record);
            return true;
        }
        public List<Record> getPendingDiskByIDCustomer(int idCustomer)
        {
            return db.Records.Where(x => x.idCustomer == idCustomer && x.rentDate == null).ToList();
        }
    
        public bool updateRentDate(Record record)
        {
            var check = db.Records.Find(record.idRecord);
            if(check != null)
            {
                check.rentDate = record.rentDate;
                check.isPaid = record.isPaid;
                check.dueDate = record.dueDate;
            }
            db.SaveChanges();
            return true;
        }

        public Result add(Record record)
        {
            db.Records.Add(record);
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
    }
}
