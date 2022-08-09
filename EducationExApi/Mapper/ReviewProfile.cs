using EducationExApi.DTO.Review;

namespace EducationExApi.Mapper
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewReadDTO>()
                .ForMember(m => m.Material, opt => opt.MapFrom(m => m.Material));
            CreateMap<ReviewCreateDTO, Review>();
            CreateMap<ReviewUpdateDTO, Review>();
        }
    }
}
