using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Walkabouts.Services.DTO;
using Walkabouts.Services.Implementations;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IAuthService authService;
        public AuthController(IAuthService _authService)
        {
            authService = _authService;
        }

        [HttpPost("register")]
        public async Task<object> Register(RegisterDTO model, string returnUrl = null)
        {


            return "AuthController";
        }


   }
}
