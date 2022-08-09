using EducationExApi.Data.DAL.UserRepositories.Interfaces;

namespace EducationExApi.Data
{
    public interface IUnitOfWork
    {
        IAuthorRepository Authors { get; }
        IMaterialRepository Materials { get; }
        IMaterialTypeRepository MaterialTypes { get; }
        IReviewRepository Reviews { get; }
        IAdminRepository Admins { get;  }

    }
}
