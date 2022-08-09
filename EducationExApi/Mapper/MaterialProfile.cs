using EducationExApi.DTO.Material;

namespace EducationExApi.Mapper
{
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {

            CreateMap<Material, MaterialReadDTO>();
            CreateMap<MaterialCreateDTO, Material>();
            CreateMap<MaterialUpdateDTO, Material>();
        }
    }
}
