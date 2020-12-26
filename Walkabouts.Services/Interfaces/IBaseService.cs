namespace Walkabouts.Services.Interfaces
{
    public interface IBaseService
    {
        // query
        T Get<T>(long id) where T : class;
     
        
        // command
        void Save<T>(T model) where T : class;
        void Delete<T>(T model) where T : class;


    }
}