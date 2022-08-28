using IdentityService.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService.Api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
