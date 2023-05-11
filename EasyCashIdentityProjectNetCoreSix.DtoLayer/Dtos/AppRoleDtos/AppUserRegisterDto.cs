using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.DtoLayer.Dtos.AppRoleDtos
{
    public class AppUserRegisterDto
    {
        //[Required(ErrorMessage = "name is required")]
        //[Display(Name="Name")]
        //[MaxLength(30,ErrorMessage = "You can enter up to 30 characters")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
 // ad, soyad, username, mail adresi, password, confirmpassword