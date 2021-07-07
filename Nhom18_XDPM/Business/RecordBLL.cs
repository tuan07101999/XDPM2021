using Business.Models;
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
    public class RecordBLL
    {
        private RecordDAL dal;
        public RecordBLL()
        {
            dal = new RecordDAL();
        }
        public Record GetDiskById(string id)
        {
            return dal.GetDiskById(id);
        }
        public List<Record> GetAllRecordUnPaid(int id)
        {
            return dal.GetAllRecordUnPaid(id);
        }
        public List<Record> GetAllRecordUnReturn(int id)
        {
            return dal.GetAllRecordUnReturn(id);
        }
        public Result UpdateDateReturnAndLateFee(Record record)
        {
            return dal.UpdateDateReturnAndLateFee(record);
        }
        public Result UpdateIsPaid(Record record)
        {
            return dal.UpdateIsPaid(record);
        }
        public List<Record> checkLateFee(int idCustomer)
        {
            return dal.checkLateFee(idCustomer);
        }
        public Record getRecordByID(int id)
        {
            return dal.getRecordByID(id);
        }
        public bool addRecord(Record record)
        {
            return dal.addRecord(record);
        }
        public List<Record> getPendingDiskByIDCustomer(int idCustomer)
        {
            return dal.getPendingDiskByIDCustomer(idCustomer);
        }
        public bool updateRentDate(Record record)
        {
            return dal.updateRentDate(record);
        }
        public Result add(Record record)
        {
            return dal.add(record);
        }
        public List<Record> GetAllRecords()
        {
            return dal.GetAllRecord();
        }
        public List<RecordModel> GetRecordsOfCustomer(int customerId)
        {
            var records = dal.GetAllRecord().Where(rec => rec.idCustomer == customerId).Select(rec => new RecordModel
            {
                TieuDe = rec.Disk.Title.name,
                NgayDenHan = rec.dueDate.Value
            });
            return records.ToList();
        }
        public List<HasOverdueModel> GetOverdueRecords(int customerId)
        {
            var records = dal.GetAllRecord().Where(rec => rec.idCustomer == customerId).Select(rec => new HasOverdueModel
            {
                TieuDe = rec.Disk.Title.name,
                NgayDenHan = rec.dueDate.Value,
                NgayTra = rec.actualReturnDate.Value,
                SoTien = rec.dueDate.Value >= DateTime.Now ? 0 : rec.lateFee.Value
            });
            return records.ToList();
        }
    }
}
