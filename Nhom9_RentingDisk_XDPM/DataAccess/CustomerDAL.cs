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
    public class CustomerDAL
    {
        private RentingDiskDBContext db;
        public CustomerDAL()
        {
            db = new RentingDiskDBContext();
        }
        public List<Customer> GetAllCustomer()
        {
            return db.Customers.ToList();
        }
        public Result add(Customer customer)
        {
            db.Customers.Add(customer);
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

        public Result update(Customer customer)
        {
            var item = db.Customers.FirstOrDefault(x => x.idCustomer.Equals(customer.idCustomer));
            if (item != null)
            {
                item.name = customer.name;
                item.address = customer.address;
                item.birthDate = customer.birthDate;
                item.email = customer.email;
                item.phoneNumber = customer.phoneNumber;

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
                    message = "Khách hàng không tồn tại",
                    isSuccess = false
                };
            }
        }

        public Result delete(int idCustomer)
        {
            var item = db.Customers.FirstOrDefault(x => x.idCustomer == idCustomer);

            if (item != null)
            {
                db.Customers.Remove(item);
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
                    message = "Xóa khách hàng thành công",
                    isSuccess = true
                };
            }
            else
            {
                return new Result
                {
                    message = "Khách hàng không tìm thấy",
                    isSuccess = false
                };
            }
        }

        public Customer searchCustomerbyId(int idCustomer) {

            return db.Customers.FirstOrDefault(x => x.idCustomer == idCustomer);
        }
        public List<Customer> getListCustomerbyID(int idCustomer)
        {
            return db.Customers.Where(x => x.idCustomer == idCustomer).ToList();
        }
        public Customer searchCustomerbyPhone(string phoneCustomer)
        {
            return db.Customers.FirstOrDefault(x => x.phoneNumber.Equals(phoneCustomer));
        }
    }
}
