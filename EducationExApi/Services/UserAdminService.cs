using EducationExApi.Data.Model.UsersModel;

namespace EducationExApi.Services
{
    public class UserAdminService : IUserAdminService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserAdminService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<AdminReadDTO> GetUser(string login, string password)
        {
            var admin = await _unitOfWork.Admins.GetUser(login, password);
            return _mapper.Map<AdminReadDTO>(admin);
        }
    }
}
