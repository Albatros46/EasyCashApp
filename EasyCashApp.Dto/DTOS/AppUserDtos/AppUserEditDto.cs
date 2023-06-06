using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.Dto.DTOS.AppUserDtos
{
    public class AppUserEditDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ImgUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
