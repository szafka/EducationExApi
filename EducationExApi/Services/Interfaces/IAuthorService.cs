using EducationExApi.DTO.Author;
using EducationExApi.DTO.Material;

namespace EducationExApi.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorReadDTO>> GetAllAuthorsAsync();
        Task<AuthorReadDTO> GetAuthorByIdAsync(int id);
        Task<AuthorReadDTO> GetAuthorWithTheHighestNumbereOfMaterialsAsync();
        Task<AuthorCreateDTO> CreateAuthorAsync(AuthorCreateDTO authorCreateDTO);
        Task UpdateAuthorAsync(int id, AuthorUpdateDTO authorUpdateDTO);
        Task DeleteAuthorAsync(int id);
    }
}