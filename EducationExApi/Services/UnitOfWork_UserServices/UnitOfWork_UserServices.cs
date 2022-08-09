namespace EducationExApi.Services.UnitOfWork_UserServices
{
    public class UnitOfWork_UserServices : IUnitOfWork_UserServices
    {
        public IMaterialTypeService MterialTypes { get; set; }
        public IMaterialService MaterialService { get; set; }
        public IAuthorService AuthorService { get; set; }
        public IMaterialTypeService MaterialTypeService { get; set; }
        public IReviewService ReviewService { get; set; }
        public UnitOfWork_UserServices(IMaterialTypeService mterialTypes, IMaterialService materialService, IAuthorService authorService, IMaterialTypeService materialTypeService, IReviewService reviewService)
        {
            MterialTypes = mterialTypes;
            MaterialService = materialService;
            AuthorService = authorService;
            MaterialTypeService = materialTypeService;
            ReviewService = reviewService;
        }
    }
}
