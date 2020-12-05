using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Repository.Context;
using Walkabouts.Services.DTO;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.Services.Implementations
{
    public class AuthService : BaseService, IAuthService
    {
        private UserManager<AppUser> userManager;

        public AuthService(WalkaboutsDbContext dbContext,UserManager<AppUser> _userManager) :base(dbContext)
        {
            userManager = _userManager;
        }
        public LoginUserResultDTO Login(LoginDTO model)
        {            
            throw new NotImplementedException();
        }

        public RegisterUserResultDTO RegisterUser(RegisterDTO model)
        {
             
            //userManager.CreateAsync()
            throw new NotImplementedException();
        }
    }
}
