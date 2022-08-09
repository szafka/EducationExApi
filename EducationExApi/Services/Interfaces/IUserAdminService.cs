using EducationExApi.Data.Model.UsersModel;

namespace EducationExApi.Services.Interfaces
{
    public interface IUserAdminService
    {
        Task<AdminReadDTO> GetUser(string login, string password);
    }
}
