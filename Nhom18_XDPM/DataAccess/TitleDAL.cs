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
    public class TitleDAL
    {

        private RentingDiskDBContext db;
        public TitleDAL()
        {
            db = new RentingDiskDBContext();
        }
        public IEnumerable<Title> GetAllTitle()
        {
            return db.Titles;
        }
        public Title GetItemTitleById(string id)
        {
            return db.Titles.FirstOrDefault(x => x.idTitle == id);
            //return db.Customers.Where(x => x.phoneNumber.Contains(sdt)).ToList();
        }
        public List<Title> GetListTitleByID(string id)
        {
            return db.Titles.Where(x => x.idTitle.Contains(id)).ToList();
        }
        public Title GetTitleByName(string namett)
        {
            return db.Titles.FirstOrDefault(x => x.name ==  namett);
        }
        public Result addTitle(Title title)
        {
            db.Titles.Add(title);
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
        public int getIdCategoryByIdTitle(string idTitle)
        {
            return db.Titles.FirstOrDefault(x => x.idTitle == idTitle).idCategory;
        }
    }
}
