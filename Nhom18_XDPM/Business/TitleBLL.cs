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
    public class TitleBLL
    {
        private TitleDAL dal;
        public TitleBLL()
        {
            dal = new TitleDAL();
        }
        public Title GetItemTitleById(string id)
        {
            return dal.GetItemTitleById(id);
        }
        public List<Title> GetListTitleByID(string id)
        {
            return dal.GetListTitleByID(id);
        }
        public Result addTitle(Title title)
        {
            return dal.addTitle(title);
        }
        public Title GetTitleByName(string namett)
        {
            return dal.GetItemTitleById(namett);
        }
    }
}
