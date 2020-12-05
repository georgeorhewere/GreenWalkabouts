using Walkabouts.Repository.Context;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.Services.Implementations
{
    public class BaseService : IBaseService
    {
        protected readonly WalkaboutsDbContext context;
        public BaseService(WalkaboutsDbContext _context)
        {
            _context = context;
        }


        public T Get<T>(long id) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Save<T>(T model) where T : class
        {
           
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T model) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}