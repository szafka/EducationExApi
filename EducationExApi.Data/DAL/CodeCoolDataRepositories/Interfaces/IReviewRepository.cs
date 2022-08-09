namespace EducationExApi.Data.DAL.CodeCoolDataRepositories.Interfaces
{
    public interface IReviewRepository : IBaseRepository<Review>
    {
        Task<Review> GetElementByIdAsync(int id);
    }
}
