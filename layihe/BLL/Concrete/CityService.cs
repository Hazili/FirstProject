using AutoMapper;
using BLL.Abstract;
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
    public class CityService : ICityService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CityService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CityAddAsync(CityToAddOrUpdateDTO cityToAddOrUpdateDTO)
        {
            City city = _mapper.Map<City>(cityToAddOrUpdateDTO);
            await _unitOfWork.CityRepository.CityAddAsync(city);
            await _unitOfWork.Commit();
        }

        public async Task<List<CityToGetDTO>> GetCityAsync()
        {
            List<City> cities = await _unitOfWork.CityRepository.GetCityAsync();
            List<CityToGetDTO> cityToGetDTOs = _mapper.Map<List<CityToGetDTO>>(cities);
            return cityToGetDTOs;
        }
    }
}
