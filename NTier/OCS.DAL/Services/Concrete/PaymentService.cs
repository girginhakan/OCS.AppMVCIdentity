﻿using AutoMapper;
using AutoMapper.EquivalencyExpression;
using AutoMapper.Extensions.ExpressionMapping;
using OCS.DAL.Profiles;
using OCS.DAL.Repositories.Abstract;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Services.Concrete
{
    public class PaymentService : Service<Payment, PaymentDto>
    {
        public PaymentService(Repo<Payment> repo) : base(repo)
        {
            MapperConfiguration _config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().AddCollectionMappers();
                cfg.AddProfile<PaymentProfile>();
            });
            base._mapper = _config.CreateMapper();
        }
    }
}
