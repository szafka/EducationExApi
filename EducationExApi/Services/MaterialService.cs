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

        public async Task<MaterialCreateDTO> AddNewElementAsync(MaterialCreateDTO materialCreateDTO)
        {
            var newMaterial = _mapper.Map<Material>(materialCreateDTO);
            var material = await _unitOfWork.Materials.AddAsync(newMaterial);
            return _mapper.Map<MaterialCreateDTO>(material);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var material = await _unitOfWork.Materials.GetElementByIdAsync(id);
            await _unitOfWork.Materials.DeleteAsync(material);
        }

        public async Task EditMaterialAsync(int id, MaterialUpdateDTO materialUpdateDTO)
        {
            var materialFromDb = await _unitOfWork.Materials.GetElementByIdAsync(id);
            _mapper.Map(materialUpdateDTO, materialFromDb);
            await _unitOfWork.Materials.UpdateAsync(materialFromDb);
        }

        public async Task<IEnumerable<MaterialReadDTO>> GetAllMaterialAsync()
        {
            var materials = await _unitOfWork.Materials.GetAllAsync();
            return _mapper.Map<IEnumerable<Material>, IEnumerable<MaterialReadDTO>>(materials.ToList());
        }

        public async Task<MaterialReadDTO> GetElementByIdAsync(int id)
        {
            var material = await _unitOfWork.Materials.GetElementByIdAsync(id);
            return _mapper.Map<MaterialReadDTO>(material);
        }

        public Task<IEnumerable<MaterialReadDTO>> GetMaterialsAverageAbove5ByAuthorIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
