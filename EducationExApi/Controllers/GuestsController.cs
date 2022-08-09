using EducationExApi.Services.UnitOfWork_UserServices;

namespace EducationExApi.Controllers
{
    [Route("api/Guests")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly ILogger<GuestsController> _logger;
        private readonly IUnitOfWork_UserServices _userService;

        public GuestsController(ILogger<GuestsController> logger, IUnitOfWork_UserServices userServices)
        {
            _logger = logger;
            _userService = userServices;
        }
        //educational material navigation points
        //educational material types
        //cru reviews
        [SwaggerOperation(Summary = "Get all materials list")]
        [HttpGet]
        public async Task<IActionResult> GetAllMaterialsAsync()
        {
            var materials = await _userService.MaterialService.GetAllMaterialAsync();
            if (materials == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(materials);
        }

        [SwaggerOperation(Summary = "Get material by id")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMaterialById(int id)
        {
            var material = await _userService.MaterialService.GetElementByIdAsync(id);
            if (material == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(material);
        }
    }
}
