using EducationExApi.Data.DAL.UserRepositories.Interfaces;

namespace EducationExApi.Data.DAL.UserRepositories
{
    public class BaseRepository<T> : IBaseUserRepository<T> where T : class
    {
    }
}
