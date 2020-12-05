using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Repository.Context;
using Walkabouts.Services.DTO;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.Services.Implementations
{
    public class AuthService : BaseService, IAuthService
    {

        public AuthService(WalkaboutsDbContext dbContext):base(dbContext)
        {

        }
        public LoginUserResultDTO Login(LoginDTO model)
        {            
            throw new NotImplementedException();
        }

        public RegisterUserResultDTO RegisterUser(RegisterDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
