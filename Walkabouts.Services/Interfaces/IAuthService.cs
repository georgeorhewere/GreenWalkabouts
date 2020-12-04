using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Services.DTO;

namespace Walkabouts.Services.Interfaces
{
    public interface IAuthService
    {
        RegisterUserResultDTO RegisterUser(RegisterDTO model);
        LoginUserResultDTO Login(LoginDTO model);
    }
}
