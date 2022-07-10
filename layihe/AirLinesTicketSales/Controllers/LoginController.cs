using BLL.Abstract;
using DAL.DataContext;
using DTO.DTOs;
using Entity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AirLinesTicketSales.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly AppDbContext _appDbContext;
        public LoginController(IUserService userService, AppDbContext appDbContext)
        {
            _userService = userService;
            _appDbContext = appDbContext;
        }
        public IActionResult LoginPage()
        {
            return View();
        }

        public async Task<IActionResult> LoginAuth(UserToAddOrUpdateDTO userToAddOrUpdateDTO)
        {
            var login = _appDbContext.Users.FirstOrDefault(x => x.UserName == userToAddOrUpdateDTO.UserName
            && x.UserPassword == userToAddOrUpdateDTO.UserPassword);

            if (login != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userToAddOrUpdateDTO.UserName)
                };

                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
                
            }

            return RedirectToAction("LoginPage");
        }

        public IActionResult RegistrationPage()
        {

            return View();
        }

        public async Task<IActionResult> Create(UserToAddOrUpdateDTO userToAddOrUpdateDTO)
        {
            await _userService.AddAsync(userToAddOrUpdateDTO);
            TempData["RegMessage"] = "Qeydiyyatdan Keçdiniz";
            return RedirectToAction("LoginPage");
        }

    }
}
