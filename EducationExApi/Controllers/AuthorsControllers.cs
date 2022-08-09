

namespace EducationExApi.Controllers
{
    //[Authorize]
    //[EnableCors("corsapp")]
    [Route("api/authors")]
    [ApiController]
    public class AuthorsControllers : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly ILogger<AuthorsControllers> _logger;
        public AuthorsControllers(IAuthorService authorService, ILogger<AuthorsControllers> logger)
        {
            _authorService = authorService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthorsAsync()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            if (authors == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(authors);
        }
    }
}
