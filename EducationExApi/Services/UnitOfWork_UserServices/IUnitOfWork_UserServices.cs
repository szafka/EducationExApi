namespace EducationExApi.Services.UnitOfWork_UserServices
{
    public interface IUnitOfWork_UserServices
    {
        IMaterialTypeService MterialTypes { get; }
        IMaterialService MaterialService { get; }
        IAuthorService AuthorService { get; }
    }
}
