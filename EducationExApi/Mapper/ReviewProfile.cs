using EducationExApi.DTO.Review;

namespace EducationExApi.Mapper
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewReadDTO>();
            CreateMap<ReviewCreateDTO, Review>();
            CreateMap<ReviewUpdateDTO, Review>();
        }
    }
}
