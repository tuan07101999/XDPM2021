using Business.Enums;
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
    public class CustomerBLL
    {
        private CustomerDAL dal;
        private RecordBLL recordBll;
        public CustomerBLL()
        {
            dal = new CustomerDAL();
            recordBll = new RecordBLL();
        }
        public Result add(Customer customer)
        {
            return dal.add(customer);
        }

        public Result update(Customer customer)
        {
            return dal.update(customer);
        }

        public Result delete(int idCustomer)
        {
            return dal.delete(idCustomer);
        }

        public Customer searchCustomerbyPhone(string phoneCustomer)
        {
            return dal.searchCustomerbyPhone(phoneCustomer);
        }
        public List<Customer> getListCustomerbyID(int idCustomer)
        {
            return dal.getListCustomerbyID(idCustomer);
        }
        public List<Customer> GetAllCustomer()
        {
            return dal.GetAllCustomer();
        }
        public Customer searchCustomerbyId(int idCustomer)
        {
            return dal.searchCustomerbyId(idCustomer);
        }

        public List<CustomerReportModel> GetCustomersReport(CustomerFilterTypeEnum customerFilterTypeEnum)
        {
            var customers = dal.GetAllCustomer();
            var customerIds = customers.Select(cus => cus.idCustomer);
            var allCustomersRecords = recordBll.GetAllRecords().Where(rec => customerIds.Contains(rec.idCustomer));
            var results = customers.Select(cus => new CustomerReportModel()
            {
                DiaChi = cus.address,
                HoTen = cus.name,
                ID = cus.idCustomer,
                SoDiaQuaHan = allCustomersRecords.Where(record => record.idCustomer == cus.idCustomer && record.dueDate < DateTime.Now).Count(),
                SoDiaThue = allCustomersRecords.Where(record => record.idCustomer == cus.idCustomer).Count(),
                SoDienThoai = cus.phoneNumber,
                LateFee = allCustomersRecords
                    .Where(record => record.idCustomer == cus.idCustomer && record.dueDate < DateTime.Now)
                    .Sum(rec => rec.lateFee)
                    .Value
            });

            switch (customerFilterTypeEnum)
            {
                case CustomerFilterTypeEnum.All:
                    return results.ToList();
                case CustomerFilterTypeEnum.HasOverdue:
                    return results.Where(rec => rec.SoDiaQuaHan > 0).ToList();
                case CustomerFilterTypeEnum.HasDebt:
                    return results.Where(rec => rec.LateFee > 0).ToList();
                default:
                    throw new Exception("Filter type not supported");
            }
        }
    }
}
