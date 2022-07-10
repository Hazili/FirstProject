using AutoMapper;
using BLL.Abstract;
using DAL.DataContext;
using DAL.UnitOfWork;
using DTO.DTOs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class DepartureCityService: IDepartureCityService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public DepartureCityService(IMapper mapper, IUnitOfWork unitOfWork, AppDbContext appDbContext)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _appDbContext = appDbContext;
        }

        public async Task<List<DepartureCityToGetDTO>> GetDepartureCities()
        {
            List<DepartureCity> departureCity = await _unitOfWork.DepartureCityRepository.GetDepartureCitiesAsync();
            List<DepartureCityToGetDTO> departureCityToGetDTO = _mapper.Map<List<DepartureCityToGetDTO>>(departureCity);
            return departureCityToGetDTO;
        }
    }
}
