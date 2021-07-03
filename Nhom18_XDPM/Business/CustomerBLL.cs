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
        public CustomerBLL()
        {
            dal = new CustomerDAL();
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
    }
}
