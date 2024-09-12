﻿using DataAccessLayer.Abstact;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstact
{
    public interface IHelpMessageDal : IGenericDal<HelpMessage>
    {

        public List<User> GetListHelpMessageByUser(List<int> id);
    }
}
