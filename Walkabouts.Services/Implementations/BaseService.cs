using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Walkabouts.Repository.Context;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.Services.Implementations
{
    public class BaseService
    {
        
        protected readonly IMapper mapper;
        public BaseService(IMapper _mapper)
        {
           
            mapper = _mapper;
        }        
        
        
        

    }
}