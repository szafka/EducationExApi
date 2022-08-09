namespace EducationExApi.Data.DAL.UserRepositories.Interfaces
{
    public interface IAdminRepository
    {
        Task<AdminReadDTO> GetUser(string login, string password);
    }
}
