﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    interface IBlogService
    {
        void BlogAdd(Blog blog);

        void BlogDelete(Blog blog);

        void BlogUpdate(Blog blog);

        List<Blog> GetList();

        Blog GetById(int id);
    }
}
