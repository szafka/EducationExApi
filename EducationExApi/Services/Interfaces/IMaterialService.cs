using EducationExApi.DTO.Material;

namespace EducationExApi.Services.Interfaces
{
    public interface IMaterialService
    {
        Task<MaterialReadDTO> GetElementByIdAsync(int id);
        Task<IEnumerable<MaterialReadDTO>> GetAllMaterialAsync();
        Task<MaterialCreateDTO> AddNewElementAsync(MaterialCreateDTO materialCreateDTO);
        Task EditMaterialAsync(int id, MaterialUpdateDTO actorDTO);
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<MaterialReadDTO>> GetMaterialsAverageAbove5ByAuthorIdAsync(int id);
    }
}
