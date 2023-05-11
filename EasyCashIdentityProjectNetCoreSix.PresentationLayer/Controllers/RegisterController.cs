using EasyCashIdentityProjectNetCoreSix.DataAccessLayer.Migrations;
using EasyCashIdentityProjectNetCoreSix.DtoLayer.Dtos.AppRoleDtos;
using EasyCashIdentityProjectNetCoreSix.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProjectNetCoreSix.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    Name = appUserRegisterDto.Name,
                    Surname = appUserRegisterDto.Surname,
                    Email = appUserRegisterDto.Email,
                    City = "BOS",
                    District = "bbb",
                    ImageUrl = "ff"
                };

                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ConfirmMail");
                } else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();

          
        }
    }
}
//var olan
// Şifre en az 6 karakterden oluşacak
// Şifre en az 1 lüçük harf içermeli
// Şifre en az 1 büyük harf içermeli
// Şifre en az 1 sayı içermeli