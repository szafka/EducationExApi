using EducationExApi.DTO.MaterialType;
using Microsoft.AspNetCore.JsonPatch;

namespace EducationExApi.Services.Interfaces
{
    public interface IMaterialTypeService
    {
        Task<MaterialTypeReadDTO> GetElementByIdAsync(int id);
        Task<IEnumerable<MaterialTypeReadDTO>> GetAllMaterialTypesAsync();
        Task<IEnumerable<MaterialTypeReadDTO>> GetMaterialsByTypeId(int id);
        Task<MaterialTypeUpdateDTO> EditMaterialTypePartialAsync(int id, JsonPatchDocument<MaterialTypeUpdateDTO> patchMaterial);
    }
}
