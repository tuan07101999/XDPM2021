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

        //Quoc
        public List<HoldingModel> GetAllHodingModels()
        {
            List<Holding> holdings = dal.GetAllHoding();
            List<HoldingModel> holdingModels = new List<HoldingModel>();

            foreach (Holding item in holdings)
            {
                HoldingModel holdingModel = new HoldingModel();

                if(item.Customer != null)
                {
                    holdingModel.customerName = item.Customer.name;
                }

                if (item.Title != null)
                {
                    holdingModel.titleName = item.Title.name;
                }
                holdingModel.idCustomer = item.idCustomer;
                holdingModel.idHolding = item.idHolding;
                holdingModel.idTitle = item.idTitle;
                holdingModel.reservationTime = item.reservationTime;

                holdingModels.Add(holdingModel);
            }
            return holdingModels;
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
