namespace EducationExApi.Data.DAL.UserRepositories.Interfaces
{
    public interface IAdminRepository
    {
        Task<Admin> GetUser(string login, string password);
    }
}
