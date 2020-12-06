using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Walkabouts.Data.DTO;

namespace Walkabouts.Services.Interfaces
{
    public interface IAuthService
    {        
        Task<ServiceResultDTO> RegisterUser(RegisterDTO model);
        ServiceResultDTO Login(LoginDTO model);
    }
}
