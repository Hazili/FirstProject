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
    public class FlyService : IFlyService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public FlyService(IMapper mapper, IUnitOfWork unitOfWork, AppDbContext appDbContext)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _appDbContext = appDbContext;
        }
        public async Task AddAsync(FlyToAddOrUpdateDTO flyToAddOrUpdateDTO)
        {

            Fly fly = _mapper.Map<Fly>(flyToAddOrUpdateDTO);
            await _unitOfWork.FlyRepository.AddAsync(fly);
            await _unitOfWork.Commit();

        }

        public async Task DeleteFlyAsync(int flyId)
        {
            List<Passenger> passenger = await _unitOfWork.PassengerRepository.GetPassengersAsync();
            foreach (var pas in passenger)
            {
                if (pas.Fly.FlyId == flyId)
                {
                    await _unitOfWork.PassengerRepository.DeletePassengerAsync(pas.PassengerId);
                    await _unitOfWork.Commit();
                }
            }

            await _unitOfWork.FlyRepository.DeleteFlyAsync(flyId);
            await _unitOfWork.Commit();
        }

        //public async Task<FlyToAddOrUpdateDTO> GetDepartureAndArrivalCity()
        //{
        //    FlyToAddOrUpdateDTO flyToAddOrUpdateDTO = new FlyToAddOrUpdateDTO();
        //    flyToAddOrUpdateDTO.ArrivalCity = _mapper.Map<List<ArrivalCityToGetDTO>>(_appDbContext.Cities.ToList());
        //    flyToAddOrUpdateDTO.DepartureCity = _mapper.Map<List<DepartureCityToGetDTO>>(_appDbContext.Cities.ToList());
        //    return flyToAddOrUpdateDTO;
        //} 

        public async Task<List<FlyToGetDTO>> GetFliesAsync()
        {
            List<Fly> flies = await _unitOfWork.FlyRepository.GetFliesAsync();
            List<FlyToGetDTO> flyToGetDTOs = _mapper.Map<List<FlyToGetDTO>>(flies);
            return flyToGetDTOs;
        }

        //public async Task<FlyToAddOrUpdateDTO> InnerMethod()
        //{
        //    FlyToAddOrUpdateDTO flyToAddOrUpdateDTO = new FlyToAddOrUpdateDTO();
        //    flyToAddOrUpdateDTO.DepartureCities = _mapper.Map<List<DepartureCityToGetDTO>>(_appDbContext.DepartureCities.ToList());
        //    return flyToAddOrUpdateDTO;
        //}
    }
}
