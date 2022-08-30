using EducationExApi.DTO.Review;

namespace EducationExApi.Services.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewReadDTO>> GetAllReviewAsync();
        Task<ReviewReadDTO> GetElementByIdAsync(int id);
        Task AddNewElementAsync(ReviewCreateDTO reviewCreateDTO);
        Task DeleteByIdAsync(int id);
        Task EditReviewlAsync(int id, ReviewUpdateDTO reviewDTO);
    }
}
