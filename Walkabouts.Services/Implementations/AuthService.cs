using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Walkabouts.Data.Domain;
using Walkabouts.Repository.Context;
using Walkabouts.Data.DTO;
using Walkabouts.Services.Interfaces;
using AutoMapper;

namespace Walkabouts.Services.Implementations
{
    public class AuthService : BaseService, IAuthService
    {
        private UserManager<AppUser> userManager;

        public AuthService(WalkaboutsDbContext dbContext,UserManager<AppUser> _userManager, IMapper mapper) :base(dbContext, mapper)
        {
            userManager = _userManager;
        }
        public ServiceResultDTO Login(LoginDTO model)
        {            
            throw new NotImplementedException();
        }

        public Task<ServiceResultDTO> RegisterUser(RegisterDTO model)
        {

            //userManager.CreateAsync()
            var userMapped = mapper.Map<AppUser>(model);
            return Task.FromResult(new ServiceResultDTO() { Success=true, Data = userMapped });
        }
    }
}
