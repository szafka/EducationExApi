using EducationExApi.DTO.MaterialType;

namespace EducationExApi.Services.Interfaces
{
    public interface IMaterialTypeService
    {
        Task<MaterialTypeReadDTO> GetElementByIdAsync(int id);
        Task<IEnumerable<MaterialTypeReadDTO>> GetAllMaterialTypesAsync();
        Task<IEnumerable<MaterialTypeReadDTO>> GetMaterialsByTypeId(int id);
    }
}
