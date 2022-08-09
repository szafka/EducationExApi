using EducationExApi.DTO.Review;

namespace EducationExApi.Controllers
{
    [Route("api/reviews")]
    [ApiController]
    public class ReviewsControllers : ControllerBase
    {
        private readonly IReviewService _reviewService;
        private readonly ILogger<ReviewsControllers> _logger;
        public ReviewsControllers(IReviewService reviewService, ILogger<ReviewsControllers> logger)
        {
            _reviewService = reviewService;
            _logger = logger;
        }

        [SwaggerOperation(Summary = "Get all review list")]
        [HttpGet]
        public async Task<IActionResult> GetAllReviewsAsync()
        {
            var reviews = await _reviewService.GetAllReviewAsync();
            if (reviews == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(reviews);
        }
        [SwaggerOperation(Summary = "Get review by id")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReviewById(int id)
        {
            var review = await _reviewService.GetElementByIdAsync(id);
            if (review == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(review);
        }
        [SwaggerOperation(Summary = "Add new review")]
        [HttpPost]
        public async Task<IActionResult> AddReviewAsync(ReviewCreateDTO reviewCreateDTO)
        {
            var newReview = await _reviewService.AddNewElementAsync(reviewCreateDTO);
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(newReview);
        }
        [SwaggerOperation(Summary = "Delete review by id")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            await _reviewService.DeleteByIdAsync(id);
            _logger.LogInformation(NoContent().StatusCode.ToString());
            return NoContent();
        }

        [SwaggerOperation(Summary = "Edit specific review")]
        [HttpPost("{id}")]
        public async Task<IActionResult> EditAsync(int id, ReviewUpdateDTO reviewDTO)
        {
            await _reviewService.EditReviewlAsync(id, reviewDTO);
            _logger.LogInformation(NoContent().StatusCode.ToString());
            return NoContent();
        }
    }
}
