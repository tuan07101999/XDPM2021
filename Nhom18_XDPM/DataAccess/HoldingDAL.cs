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
    public class HoldingDAL
    {
        private RentingDiskDBContext db;
        public HoldingDAL()
        {
            db = new RentingDiskDBContext();
        }
        public List<Holding> GetAllHoding()
        {
            return db.Holdings.ToList();
        }

        public Result add(Holding holding)
        {
            db.Holdings.Add(holding);
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

        public Result delete(int idHolding)
        {
            var item = db.Holdings.FirstOrDefault(x => x.idHolding == idHolding);

            if (item != null)
            {
                db.Holdings.Remove(item);
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
                    message = "Xóa đơn đặt hàng thành công",
                    isSuccess = true
                };
            }
            else
            {
                return new Result
                {
                    message = "Không tìm thấy đơn hàng",
                    isSuccess = false
                };
            }
        }

        public Result update(Holding holding)
        {
            var item = db.Holdings.FirstOrDefault(x => x.idHolding == holding.idHolding);
            if (item != null)
            {
                item.idCustomer = holding.idCustomer;
                item.idTitle = holding.idTitle;
                item.reservationTime = holding.reservationTime;
                
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
                    message = "Đơn đặt hàng không tồn tại",
                    isSuccess = false
                };
            }
        }

        public List<Holding> getListReservationByCustomerID(int idCustomer)
        {
            return db.Holdings.Where(x => x.idCustomer == idCustomer).ToList();
        }
    }
}
