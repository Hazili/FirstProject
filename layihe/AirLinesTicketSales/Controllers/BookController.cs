using AutoMapper;
using BLL.Abstract;
using DAL.DataContext;
using DAL.UnitOfWork;
using DTO.DTOs;
using Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AirLinesTicketSales.Controllers
{
    public class BookController : Controller
    {

        private readonly IFlyService _flyService;
        private readonly ICityService _cityService;
        private readonly IPilotGaleryService _pilotGaleryService;
        private readonly IPassengerService _passengerService;
        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;
        private readonly IUnitOfWork _unitOfWork;

        public BookController(IFlyService flyService, ICityService cityService, AppDbContext appDbContext, IMapper mapper, IPilotGaleryService pilotGaleryService, IPassengerService passengerService, IUnitOfWork unitOfWork)
        {
            _flyService = flyService;
            _cityService = cityService;
            _pilotGaleryService = pilotGaleryService;
            _mapper = mapper;
            _appDbContext = appDbContext;
            _passengerService = passengerService;
            _unitOfWork = unitOfWork;
        }
        [Authorize]
        public async Task<IActionResult> Book()
        {
            List<FlyToGetDTO> flyToGetDTOs = await _flyService.GetFliesAsync();


            return View(flyToGetDTOs);
        }

        [Authorize]
        public async Task<IActionResult> FlyForm()
        {
            List<CityToGetDTO> cityToGetDTOs = await _cityService.GetCityAsync();
            FlyToAddOrUpdateDTO flyToAddOrUpdateDTO = new FlyToAddOrUpdateDTO()
            {
                City = cityToGetDTOs
            };
            TempData["CreateFly"] = "Uçuş Yaradıldı.....";
            return View(flyToAddOrUpdateDTO);
        }


        [Authorize]
        public async Task<IActionResult> CreateFlyForm(FlyToAddOrUpdateDTO flyToAddOrUpdateDTO)
        {
            await _flyService.AddAsync(flyToAddOrUpdateDTO);
            return RedirectToAction("Book");
        }

        [Authorize]
        public async Task<IActionResult> AddCity(CityToAddOrUpdateDTO cityToAddOrUpdateDTO)
        {
            await _cityService.CityAddAsync(cityToAddOrUpdateDTO);
            TempData["CityMessage"] = "Şəhər Əlavə Edildi.....";
            return RedirectToAction("Cities");
        }

        [Authorize]
        public IActionResult Cities()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Ticket()
        {
            List<PassengerToGetDTO> passengerToGetDTO = await _passengerService.GetPassengersAsync();
            Nullable<int> id = passengerToGetDTO.Max(x => x.PassengerId);
            PassengerToGetDTO passengerToGetDTO_2 = new PassengerToGetDTO();

            foreach (var pas in passengerToGetDTO)
            {
                if (pas.PassengerId == id)
                {
                    passengerToGetDTO_2 = pas;

                }

            }
            return View(passengerToGetDTO_2);
        }

        [Authorize]
        public async Task<IActionResult> Pilots()
        {
            List<PilotGaleryToGetDTO> pilotGaleryToGetDTO = await _pilotGaleryService.GetPilotGaleries();
            return View(pilotGaleryToGetDTO);
        }

        [Authorize]
        public IActionResult PilotAddForm()
        {
            return View();
        }

        [Authorize]
        public IActionResult CreatePilotImg(AddPilotImage addPilotImage)
        {
            PilotGaleryToAddDTO pilotGaleryToAddDTO = new PilotGaleryToAddDTO();
            if (addPilotImage.ImageURL != null)
            {
                var extension = Path.GetExtension(addPilotImage.ImageURL.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Pilots/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                addPilotImage.ImageURL.CopyTo(stream);
                pilotGaleryToAddDTO.ImageURL = newImageName;
            }

            pilotGaleryToAddDTO.Id = addPilotImage.PilotId;
            pilotGaleryToAddDTO.FullName = addPilotImage.PilotFullName;
            _pilotGaleryService.PilotGaleryAddAsync(pilotGaleryToAddDTO);

            return RedirectToAction("Pilots");
        }

        [Authorize]
        public async Task<IActionResult> FlyRegistrationForm(int flyId)
        {
            Fly fly = new Fly();
            fly = _appDbContext.Flies.First(x => x.FlyId == flyId);
            PassengerToAddDTO passengerToAddDTO = new PassengerToAddDTO();
            passengerToAddDTO.FlyToAddOrUpdateDTO = _mapper.Map<FlyToAddOrUpdateDTO>(fly);
            return View(passengerToAddDTO);
        }

        [Authorize]
        public async Task<IActionResult> CreateTicket(int? id, PassengerToAddDTO passengerToAddDTO)
        {
            Fly fly = new Fly();
            fly = _appDbContext.Flies.First(x => x.FlyId == id);
            passengerToAddDTO.FlyToAddOrUpdateDTO = _mapper.Map<FlyToAddOrUpdateDTO>(fly);
            await _passengerService.PassengerAddAsync(passengerToAddDTO);
            
            return RedirectToAction("Ticket");
        }

        [Authorize]
        public async Task<IActionResult> DeleteFly(int flyId)
        {
            List<FlyToGetDTO> flyToGetDTO = await _flyService.GetFliesAsync();
            foreach (var fly in flyToGetDTO)
            {
                int resp = fly.Capacity / 2;
                if (fly.FlyId == flyId && fly.NumberOfTicket >= resp)
                {
                    TempData["AlertMessage"] = "Uçuş ləğv edildi.....";
                    await _flyService.DeleteFlyAsync(flyId);
                    
                }
                if (fly.FlyId == flyId && fly.NumberOfTicket < resp)
                {
                    TempData["AlertMessage_2"] = "Uçuş ləğv edilə bilməz.....";
                }
            }
            return RedirectToAction("Book");
        }

        [Authorize]
        public async Task<IActionResult> Reports()
        {
            List<PassengerToGetDTO> passengerToGetDTO = await _passengerService.GetPassengersAsync();
            return View(passengerToGetDTO);
        }

        [Authorize]
        public IActionResult ReturnTicketView()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> ReturnTicket(int passengerId)
        {
            List<PassengerToGetDTO> passengerToGetDTOs = await _passengerService.GetPassengersAsync();
            List<FlyToGetDTO> flyToGetDTOs = await _flyService.GetFliesAsync();
            foreach (var passenger in passengerToGetDTOs)
            {
                if (passengerId == passenger.PassengerId && passenger.Fly.DateTime > DateTime.Now)
                {
                    await _passengerService.DeletePassengerAsync(passengerId);
                    return RedirectToAction("ReturnTicketView");

                }
            }

            TempData["AlertMessage"] = "Bilet İadə Edilə bilməz. Uçuş Vaxtı Keçmişdir....";
            return RedirectToAction("Reports");
        }
    }
}
