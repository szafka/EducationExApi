using EducationExApi.DTO.Review;

namespace EducationExApi.Controllers
{
    [Authorize]
    [EnableCors("corsapp")]
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

        [SwaggerOperation(Summary = "Delete review by id")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            await _reviewService.DeleteByIdAsync(id);
            _logger.LogInformation(NoContent().StatusCode.ToString());
            return NoContent();
        }
    }
}
