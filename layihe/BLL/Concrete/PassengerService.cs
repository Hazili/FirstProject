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
    public class PassengerService : IPassengerService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PassengerService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task DeletePassengerAsync(int passengerId)
        {
            await _unitOfWork.PassengerRepository.DeletePassengerAsync(passengerId);
            await _unitOfWork.Commit();
        }

        public async Task<List<PassengerToGetDTO>> GetPassengersAsync()
        {
            List<Passenger> passenger = await _unitOfWork.PassengerRepository.GetPassengersAsync();
            List<PassengerToGetDTO> passengerToGetDTO = _mapper.Map<List<PassengerToGetDTO>>(passenger);
            return passengerToGetDTO;
        }

        public async Task PassengerAddAsync(PassengerToAddDTO passengerToAddDTO)
        {
            Passenger passenger = new Passenger();
            List<Fly> fly = await _unitOfWork.FlyRepository.GetFliesAsync();
            Fly fly1 = fly.FirstOrDefault(x => x.FlyId == passengerToAddDTO.FlyToAddOrUpdateDTO.FlyId);
            passenger = _mapper.Map<Passenger>(passengerToAddDTO);
            passenger.Fly = _mapper.Map<Fly>(fly1);
            int newNumberOfTicket = passenger.Fly.NumberOfTicket - 1;
            passenger.Fly.NumberOfTicket = newNumberOfTicket;
            await _unitOfWork.PassengerRepository.PassengerAddAsync(passenger);
            await _unitOfWork.Commit();
        }
    }
}
