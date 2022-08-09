namespace EducationExApi.Controllers
{
    [Route("api/materials")]
    [ApiController]
    public class MaterialsControllers : ControllerBase
    {
        private readonly IMaterialService _materialService;
        private readonly ILogger<MaterialsControllers> _logger;
        public MaterialsControllers(IMaterialService materialService, ILogger<MaterialsControllers> logger)
        {
            _materialService = materialService;
            _logger = logger;
        }
        //CRUD
        //materials by author id
        [SwaggerOperation(Summary = "Get all materials list")]
        [HttpGet]
        public async Task<IActionResult> GetAllMaterialsAsync()
        {
            var materials = await _materialService.GetAllMaterialAsync();
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
            var material = await _materialService.GetElementByIdAsync(id);
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
