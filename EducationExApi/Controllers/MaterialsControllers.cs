using EducationExApi.DTO.Material;

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
        [SwaggerOperation(Summary = "Add new material")]
        [HttpPost]
        public async Task<IActionResult> AddMaterialAsync(MaterialCreateDTO materialCreateDTO)
        {
            var newMaterial = await _materialService.AddNewElementAsync(materialCreateDTO);
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(newMaterial);
        }
        [SwaggerOperation(Summary = "Delete material by id")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            await _materialService.DeleteByIdAsync(id);
            _logger.LogInformation(NoContent().StatusCode.ToString());
            return NoContent();
        }

        [SwaggerOperation(Summary = "Edit specific material")]
        [HttpPost("{id}")]
        public async Task<IActionResult> EditAsync(int id, MaterialUpdateDTO materialDTO)
        {
            await _materialService.EditMaterialAsync(id, materialDTO);
            _logger.LogInformation(NoContent().StatusCode.ToString());
            return NoContent();
        }

        // TODO

        //[SwaggerOperation(Summary = "Get materials with average above 5 by author id")]
        //[HttpGet("{id}/materials/{autorId}")]
        //public async Task<IEnumerable<MaterialReadDTO>> GetMaterialsAverageAbove5ByAuthorIdAsync(int id)
        //{
        //    var materialsRateAbove5 = _materialService.GetMaterialsAverageAbove5ByAuthorIdAsync(id);

        //}
    }
}
