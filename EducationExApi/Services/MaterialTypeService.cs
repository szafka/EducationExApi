using EducationExApi.DTO.MaterialType;
using Microsoft.AspNetCore.JsonPatch;

namespace EducationExApi.Services
{
    public class MaterialTypeService : IMaterialTypeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public MaterialTypeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<MaterialTypeUpdateDTO> EditMaterialTypePartialAsync(int id, JsonPatchDocument<MaterialTypeUpdateDTO> patchMaterial)
        {
            var materialTypeFromDB = await _unitOfWork.MaterialTypes.GetByIdAsync(id);
            return _mapper.Map<MaterialTypeUpdateDTO>(materialTypeFromDB);
            
        }

        public async Task<IEnumerable<MaterialTypeReadDTO>> GetAllMaterialTypesAsync()
        {
            var materialTypes = await _unitOfWork.MaterialTypes.GetAllAsync();
            return _mapper.Map<IEnumerable<MaterialTypeReadDTO>>(materialTypes);
        }

        public async Task<MaterialTypeReadDTO> GetElementByIdAsync(int id)
        {
            var materialType = await _unitOfWork.MaterialTypes.GetByIdAsync(id);
            return _mapper.Map<MaterialTypeReadDTO>(materialType);
        }

        public async Task<IEnumerable<MaterialTypeReadDTO>> GetMaterialsByTypeId(int id)
        {
            var materialTypeById = await _unitOfWork.MaterialTypes.GetByIdAsync(id);
            var materialsByTypeId = materialTypeById.Materials;
            return _mapper.Map<IEnumerable<MaterialTypeReadDTO>>(materialsByTypeId);
        }
    }
}
