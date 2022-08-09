using EducationExApi.Data.DAL.UserRepositories.Interfaces;

namespace EducationExApi.Data.DAL.UserRepositories
{
    public class AdminRepository : BaseRepository<AdminReadDTO>, IAdminRepository
    {
        private readonly API_Context _context;
        public AdminRepository(API_Context context)
        {
            _context = context;
        }
        public async Task<AdminReadDTO> GetUser(string login, string password)
        {
            return await _context.Admins.FirstOrDefaultAsync(u => u.Credentials.Login == login && u.Credentials.Password == password);
        }
    }
}
