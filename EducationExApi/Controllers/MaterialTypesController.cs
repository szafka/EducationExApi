using EducationExApi.DTO.MaterialType;
using Microsoft.AspNetCore.JsonPatch;

namespace EducationExApi.Controllers
{
    [Authorize]
    [EnableCors("corsapp")]
    [Route("api/materialTypes")]
    [ApiController]
    public class MaterialTypesController : ControllerBase
    {
        private readonly ILogger<MaterialTypesController> _logger;
        private readonly IMaterialTypeService _materialTypeService;
        public MaterialTypesController(ILogger<MaterialTypesController> logger, IMaterialTypeService materialTypeService)
        {
            _logger = logger;
            _materialTypeService = materialTypeService;
        }

        [SwaggerOperation( Summary = "Get materials by types id")]
        [HttpGet("{id}/materials")]
        public async Task<IActionResult> GetAllMaterialsByTypeId(int id)
        {
            var materials = _materialTypeService.GetMaterialsByTypeId(id);
            if (materials == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(materials);
        }
        [SwaggerOperation(Summary = "Update by using patch")]
        [HttpPatch("{id}")]
        public async Task<IActionResult> PartialCommandUpdate(int id, JsonPatchDocument<MaterialTypeUpdateDTO> patchMaterial)
        {
            {
                await _materialTypeService.EditMaterialTypePartialAsync(id, patchMaterial);
                _logger.LogInformation(NoContent().StatusCode.ToString());
                return NoContent();
            }
        }
    }
}
