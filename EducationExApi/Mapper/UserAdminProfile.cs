using EducationExApi.Data.Model.UsersModel;
using EducationExApi.DTO.UserAdmin;

namespace EducationExApi.Mapper
{
    public class UserAdminProfile : Profile
    {
        public UserAdminProfile()
        {
            CreateMap<Admin, UserAdminReadDTO>();
            CreateMap<UserAdminCreateDTO, Admin>();
        }
    }
}
