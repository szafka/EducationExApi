namespace EducationExApi.Controllers
{
    [Route("api/materials")]
    [ApiController]
    public class MaterialsControllers : ControllerBase
    {
        private readonly IMaterialService _authorService;
        private readonly ILogger<MaterialsControllers> _logger;
        public MaterialsControllers(IMaterialService authorService, ILogger<MaterialsControllers> logger)
        {
            _authorService = authorService;
            _logger = logger;
        }
    }
}
