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
    public class HoldingBLL
    {
        private HoldingDAL dal;
        public HoldingBLL()
        {
            dal = new HoldingDAL();
        }

        public List<Holding> GetAllHoding()
        {
            return dal.GetAllHoding();
        }

        public Result add(Holding holding)
        {
            return dal.add(holding);
        }
        public Result delete(int idHolding)
        {
            return dal.delete(idHolding);
        }

        public Result update(Holding holding)
        {
            return dal.update(holding);
        }

        public List<Holding> getListReservationByCustomerID(int idCustomer)
        {
            return dal.getListReservationByCustomerID(idCustomer);
        }
    }
}
