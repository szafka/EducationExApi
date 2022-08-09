



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
        [SwaggerOperation(Summary = "Get all authors")]
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
        [SwaggerOperation(Summary = "Get author by id")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorByIdAsync(int id)
        {
            var author = await _authorService.GetAuthorByIdAsync(id);
            if (author == null)
            {
                _logger.LogInformation(NotFound().StatusCode.ToString());
                return NotFound();
            }
            _logger.LogInformation(Ok().StatusCode.ToString());
            return Ok(author);
        }
        //[SwaggerOperation(Summary = "Get author with the most materials")]
        //[HttpGet]
        //public async Task<IActionResult> GetAuthorMostMaterialsAsync()
        //{
        //    var author = _authorService.GetAuthorWithTheHighestNumbereOfMaterialsAsync();
        //    if (author == null)
        //    {
        //        _logger.LogInformation(NotFound().StatusCode.ToString());
        //        return NotFound();
        //    }
        //    _logger.LogInformation(Ok().StatusCode.ToString());
        //    return Ok(author);
        //}

    }
}
