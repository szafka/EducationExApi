using EducationExApi.DTO.Material;

namespace EducationExApi.Services.Interfaces
{
    public interface IMaterialService
    {
        Task<MaterialReadDTO> GetElementByIdAsync(int id);
        Task<IEnumerable<MaterialReadDTO>> GetAllMaterialAsync();
    }
}
