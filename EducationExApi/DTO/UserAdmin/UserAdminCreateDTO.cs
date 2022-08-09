using EducationExApi.Data.Model.UsersModel;

namespace EducationExApi.DTO.UserAdmin
{
    public class UserAdminCreateDTO
    {
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(25)]
        public string? Surname { get; set; }
        [Required]
        [MaxLength(25)]
        public string? Nickname { get; set; }
        public CredentialsContainer? Credentials { get; set; }
    }
}
