﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category);

        void CategoryDelete(Category category);

        void CategoryUpdate(Category category);

        List<Category> GetList();

        Category GetById(int id); 


    }
}
