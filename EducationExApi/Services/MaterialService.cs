using EducationExApi.DTO.Material;

namespace EducationExApi.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public MaterialService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<MaterialReadDTO>> GetAllMaterialAsync()
        {
            var materials = await _unitOfWork.Materials.GetAllAsync();
            return _mapper.Map<IEnumerable<MaterialReadDTO>>(materials);
        }

        public async Task<MaterialReadDTO> GetElementByIdAsync(int id)
        {
            var material = await _unitOfWork.Materials.GetByIdAsync(id);
            return _mapper.Map<MaterialReadDTO>(material);
        }
    }
}
