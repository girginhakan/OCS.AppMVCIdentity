﻿using AutoMapper;
using OCS.DTO;
using OCS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Abstract
{
    public interface IManager<Tdto,TViewModel> 
        where Tdto : BaseDto
        where TViewModel:BaseViewModel
    {
        IMapper Mapper { set; }
        int Add(TViewModel viewModel);
        int Update(TViewModel viewModel);
        int Delete(TViewModel viewModel);
        IEnumerable<TViewModel> GetAll();
        TViewModel? Get(int id);
    }
}
