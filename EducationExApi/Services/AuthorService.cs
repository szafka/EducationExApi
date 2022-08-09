using EducationExApi.DTO.Material;

namespace EducationExApi.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<AuthorCreateDTO> CreateAuthorAsync(AuthorCreateDTO authorCreateDTO)
        {
            var newAuthor = _mapper.Map<Author>(authorCreateDTO);
            var author = await _unitOfWork.Authors.AddAsync(newAuthor);
            return _mapper.Map<AuthorCreateDTO>(author);
        }

        public async Task DeleteAuthorAsync(int id)
        {
            var authorToDelete = await _unitOfWork.Authors.GetAuthorByIdAsync(id);
            await _unitOfWork.Authors.DeleteAsync(authorToDelete);
        }

        public async Task<IEnumerable<AuthorReadDTO>> GetAllAuthorsAsync()
        {
            var authors = await _unitOfWork.Authors.GetAllAsync();
            return _mapper.Map<IEnumerable<AuthorReadDTO>>(authors);
        }

        public async Task<AuthorReadDTO> GetAuthorByIdAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetAuthorByIdAsync(id);
            return _mapper.Map<AuthorReadDTO>(author);
        }

        public async Task<AuthorReadDTO> GetAuthorWithTheHighestNumbereOfMaterialsAsync()
        {
            var author = await _unitOfWork.Authors.GetAuthorWithTheMostMaterialsAsync();
            return _mapper.Map<AuthorReadDTO>(_mapper.Map<AuthorReadDTO>(author));
        }

        public Task<IEnumerable<MaterialReadDTO>> GetMaterialsAverageAbove5ByAuthorIdAsync(int id)
        {
            var authorById = _unitOfWork.Authors.GetAuthorByIdAsync(id);
            var materials = authorById.
        }

        public async Task UpdateAuthorAsync(int id, AuthorUpdateDTO authorUpdateDTO)
        {
            var authorToUpdate = await _unitOfWork.Authors.GetAuthorByIdAsync(id);
            _mapper.Map(authorUpdateDTO, authorToUpdate);
            await _unitOfWork.Authors.UpdateAsync(authorToUpdate);
        }
    }
}
