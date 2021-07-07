﻿using DataAccess;
using DataAccess.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryBLL
    {
        private CategoryDAL dal;
        public CategoryBLL()
        {
            dal = new CategoryDAL();
        }

        public Result update(Category category)
        {
            return dal.UpdateCategory(category);
        }
        public float getRentalChargeById(int id)
        {
            return dal.getRentalChargeById(id);
        }
        public Category getCategoryById(int id)
        {
            return dal.getCategoryById(id);
        }
    }
}
