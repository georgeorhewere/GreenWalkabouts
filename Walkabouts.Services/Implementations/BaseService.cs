using AutoMapper;
using Walkabouts.Repository.Context;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.Services.Implementations
{
    public class BaseService : IBaseService
    {
        protected readonly WalkaboutsDbContext context;
        protected readonly IMapper mapper;
        public BaseService(WalkaboutsDbContext _context, IMapper _mapper)
        {
           context = _context;
            mapper = _mapper;
        }


        public T Get<T>(long id) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Save<T>(T model) where T : class
        {

            context.SaveChangesAsync();
         
        }

        public void Delete<T>(T model) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}