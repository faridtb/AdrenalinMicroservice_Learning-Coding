using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService.Api.DTOs
{
    public class LoginResponseDto
    {
        public string Username { get; set; }
        public string UserToken { get; set; }
    }
}
