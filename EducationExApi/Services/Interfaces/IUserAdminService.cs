using EducationExApi.Data.Model.UsersModel;

namespace EducationExApi.Services.Interfaces
{
    public interface IUserAdminService
    {
        Task<Admin> GetUser(string login, string password);
    }
}
