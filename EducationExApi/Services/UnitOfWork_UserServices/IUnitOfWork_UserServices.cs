namespace EducationExApi.Services.UnitOfWork_UserServices
{
    public interface IUnitOfWork_UserServices
    {
        IMaterialTypeService MterialTypes { get; }
        IMaterialService MaterialService { get; }
        IAuthorService AuthorService { get; }
        IMaterialTypeService MaterialTypeService { get; }
        IReviewService ReviewService { get; }
    }
}
