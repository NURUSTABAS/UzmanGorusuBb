﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ILinkDal : IGenericDal<Link>
    {
        List<Link> GetListWithCategory();
        List<Link> GetListWithCategoryByApplicant(int id);
    }
}
