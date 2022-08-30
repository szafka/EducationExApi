using EducationExApi.Data.PaginatedList;
using EducationExApi.DTO.Review;
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

        [SwaggerOperation(Summary = "Get all materials list")]
        [HttpGet]
        public async Task<IActionResult> GetAllMaterialsAsync([FromQuery] PaginatedListParameters paginatedListParameters)
        {
            var materials = await _userService.MaterialService.GetAllMaterialsPaginatedListAsync(paginatedListParameters);
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
        [SwaggerOperation(Summary = "Get all material types")]
        [HttpGet("materialTypes")]
        public async Task<IActionResult> GertAllMaterialTypes()
        {
            var materials = await _userService.MaterialTypeService.GetAllMaterialTypesAsync();
            if (materials == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(materials);
        }
        [SwaggerOperation(Summary = "Get material type by id")]
        [HttpGet("{id}/materialTypes")]
        public async Task<IActionResult> GetMaterialTypeById(int id)
        {
            var material = await _userService.MaterialTypeService.GetElementByIdAsync(id);
            if (material == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(material);
        }

        [SwaggerOperation(Summary = "Get all review list")]
        [HttpGet("ReviewList")]
        public async Task<IActionResult> GetAllReviewsAsync()
        {
            var reviews = await _userService.ReviewService.GetAllReviewAsync();
            if (reviews == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(reviews);
        }
        [SwaggerOperation(Summary = "Get review by id")]
        [HttpGet("Review/{id}")]
        public async Task<IActionResult> GetReviewById(int id)
        {
            var review = await _userService.ReviewService.GetElementByIdAsync(id);
            if (review == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(review);
        }
        [SwaggerOperation(Summary = "Add new review")]
        [HttpPost("AddReview")]
        public async Task<IActionResult> AddReviewAsync(ReviewCreateDTO reviewCreateDTO)
        {
            await _userService.ReviewService.AddNewElementAsync(reviewCreateDTO);
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok();
        }

        [SwaggerOperation(Summary = "Edit specific review")]
        [HttpPut("Edit")]
        public async Task<IActionResult> EditAsync(int id, ReviewUpdateDTO reviewDTO)
        {
            await _userService.ReviewService.EditReviewlAsync(id, reviewDTO);
            _logger.LogInformation(NoContent().StatusCode.ToString());
            return NoContent();
        }
    }
}
