using AutoMapper;
using DTO.DTOs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class MyAutoMappers : Profile
    {
        public MyAutoMappers()
        {
            CreateMap<User, UserToAddOrUpdateDTO>().ReverseMap();

            CreateMap<Fly, FlyToAddOrUpdateDTO>().ReverseMap();
            CreateMap<Fly, FlyToGetDTO>().ReverseMap();
            CreateMap<Fly, FlyToDeleteDTO>().ReverseMap();

            CreateMap<FlyToAddOrUpdateDTO, FlyToGetDTO>().ReverseMap();
            CreateMap<FlyToAddOrUpdateDTO, PassengerToAddDTO>().ReverseMap();
            CreateMap<FlyToAddOrUpdateDTO, DepartureCityToGetDTO>().ReverseMap();

            CreateMap<City, CityToGetDTO>().ReverseMap();
            CreateMap<City, CityToAddOrUpdateDTO>().ReverseMap();

            CreateMap<Passenger, PassengerToAddDTO>().ReverseMap();
            CreateMap<Passenger, PassengerToGetDTO>().ReverseMap();

            CreateMap<PilotGalery, PilotGaleryToAddDTO>().ReverseMap();
            CreateMap<PilotGalery, PilotGaleryToGetDTO>().ReverseMap();

            CreateMap<DepartureCity, DepartureCityDTO>().ReverseMap();
            CreateMap<ArrivalCity, ArrivalCityDTO>().ReverseMap();
            CreateMap<ArrivalCityDTO, City>().ReverseMap();
            // CreateMap<DepartureCityDTO, City>().ReverseMap();
            CreateMap<DepartureCity, DepartureCityToGetDTO>().ReverseMap();
            CreateMap<ArrivalCity, ArrivalCityToGetDTO>().ReverseMap();


        }
    }
}
