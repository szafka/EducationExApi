using EducationExApi.Data.PaginatedList;
using EducationExApi.DTO.Material;

namespace EducationExApi.Mapper
{
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {

            CreateMap<Material, MaterialReadDTO>()
                .ForMember(m => m.MaterialType, opt => opt.MapFrom(s => s.MaterialType.Type))
                .ForMember(a => a.Author, opt => opt.MapFrom(a => a.Author.Name))
                .ForMember(pd => pd.PublicationDate, opt => opt.MapFrom(pd => pd.PublicationDate));
            CreateMap<MaterialCreateDTO, Material>();
            CreateMap<MaterialUpdateDTO, Material>();
            CreateMap<PaginatedList<Material>, PaginatedMaterialReadDTO>().ForMember(m => m.Materials, act => act.MapFrom(src => src.ToList()));
        }
    }
}
