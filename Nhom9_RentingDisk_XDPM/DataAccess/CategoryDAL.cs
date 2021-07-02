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
    public class CategoryDAL
    {
        private RentingDiskDBContext db;
        public CategoryDAL()
        {
            db = new RentingDiskDBContext();
        }
        public Result UpdateCategory(Category category)
        {
            var item = db.Categories.FirstOrDefault(x => x.idCategory.Equals(category.idCategory));
            if (item != null)
            {
                item.rentalCharge = category.rentalCharge;
                item.rentalPeriod = category.rentalPeriod;
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
                    message = "Cập nhập thất bại",
                    isSuccess = false
                };
            }
        }
    }
}
