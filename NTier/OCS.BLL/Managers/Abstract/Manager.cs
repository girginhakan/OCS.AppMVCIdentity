using AutoMapper;
using AutoMapper.EquivalencyExpression;
using AutoMapper.Extensions.ExpressionMapping;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Abstract;
using OCS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Abstract
{
    public abstract class Manager<TDto, TViewModel, TEntity> : IManager<TDto, TViewModel>
        where TViewModel : BaseViewModel
        where TEntity : BaseEntity
        where TDto : BaseDto
    {
        protected Service<TEntity, TDto> _service;
        protected IMapper _mapper;
        protected int _appUserId;

        protected Manager(Service<TEntity, TDto> service)
        {
            MapperConfiguration _config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().AddCollectionMappers();
                cfg.CreateMap<TDto, TViewModel>().ReverseMap();
            });
            _mapper = _config.CreateMapper();
            _service = service;
        }

        public IMapper Mapper
        {
            set { _mapper = value; }
        }

        public int Add(TViewModel viewModel)
        {
            TDto dto = _mapper.Map<TDto>(viewModel);
            return _service.Add(dto);

        }

        public int Delete(TViewModel viewModel)
        {
            TDto dto = _mapper.Map<TDto>(viewModel);
            return _service.Delete(dto);
        }

        public int Delete(int id)
        {
            return _service.Delete(id);
        }


        public TViewModel? Get(int id)
        {
            TDto? dto = _service.Get(id);
            return _mapper.Map<TViewModel>(dto);
        }

        public virtual IEnumerable<TViewModel> GetAll()
        {
            IEnumerable<TDto> list = _service.GetAll().ToList();

            return _mapper.Map<IEnumerable<TViewModel>>(list);

        }

        public int Update(TViewModel viewModel)
        {
            TDto dto = _mapper.Map<TDto>(viewModel);
            return _service.Update(dto);
        }
    }
}
