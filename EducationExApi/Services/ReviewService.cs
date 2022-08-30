using EducationExApi.DTO.Review;

namespace EducationExApi.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ReviewService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task AddNewElementAsync(ReviewCreateDTO reviewCreateDTO)
        {
            var newReview = _mapper.Map<Review>(reviewCreateDTO);
            await _unitOfWork.Reviews.AddAsync(newReview);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var review = await _unitOfWork.Reviews.GetElementByIdAsync(id);
            await _unitOfWork.Reviews.DeleteAsync(review);
        }

        public async Task EditReviewlAsync(int id, ReviewUpdateDTO reviewDTO)
        {
            var reviewFromDb = await _unitOfWork.Reviews.GetElementByIdAsync(id);
            _mapper.Map(reviewDTO, reviewFromDb);
            await _unitOfWork.Reviews.UpdateAsync(reviewFromDb);
        }

        public async Task<IEnumerable<ReviewReadDTO>> GetAllReviewAsync()
        {
            var reviews = await _unitOfWork.Reviews.GetAllAsync();
            return _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewReadDTO>>(reviews);
        }

        public async Task<ReviewReadDTO> GetElementByIdAsync(int id)
        {
            var material = await _unitOfWork.Reviews.GetElementByIdAsync(id);
            return _mapper.Map<ReviewReadDTO>(material);
        }
    }
}
