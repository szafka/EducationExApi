using EducationExApi.DTO.Material;

namespace EducationExApi.Controllers
{
    [Authorize]
    [EnableCors("corsapp")]
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

        [SwaggerOperation(Summary = "Add new material")]
        [HttpPost]
        public async Task<IActionResult> AddMaterialAsync(MaterialCreateDTO materialCreateDTO)
        {
            await _materialService.AddNewElementAsync(materialCreateDTO);
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok();
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
        [HttpPut("{id}")]
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
