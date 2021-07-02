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
    }
}
