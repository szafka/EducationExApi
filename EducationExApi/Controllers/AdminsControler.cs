using EducationExApi.Services.UnitOfWork_UserServices;

namespace EducationExApi.Controllers
{
    [Route("api/Admins")]
    [ApiController]
    public class AdminsControler : ControllerBase
    {
        private readonly ILogger<AdminsControler> _logger;
        public AdminsControler(ILogger<AdminsControler> logger)
        {
            _logger = logger;
        }
    }
}
