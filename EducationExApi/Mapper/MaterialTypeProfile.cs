using EducationExApi.DTO.MaterialType;

namespace EducationExApi.Mapper
{
    public class MaterialTypeProfile : Profile
    {
        public MaterialTypeProfile()
        {

            CreateMap<MaterialType, MaterialTypeReadDTO>();
            CreateMap<MaterialTypeCreateDTO, MaterialType>();
            CreateMap<MaterialTypeUpdateDTO, MaterialType>();
        }
    }
}
