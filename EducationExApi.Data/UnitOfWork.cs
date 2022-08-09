using EducationExApi.Data.DAL.UserRepositories;
using EducationExApi.Data.DAL.UserRepositories.Interfaces;

namespace EducationExApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAuthorRepository Authors { get; set; }
        public IReviewRepository Reviews { get; set; }
        public IMaterialRepository Materials { get; set; }
        public IMaterialTypeRepository MaterialTypes { get; set; }
        public IAdminRepository Admins { get; set; }
        public UnitOfWork(IAuthorRepository authors, IMaterialTypeRepository materialTypes, IMaterialRepository materials, IReviewRepository reviews, IAdminRepository admins)
        {
            Authors = authors;
            Reviews = reviews;
            Materials = materials;
            MaterialTypes = materialTypes;
            Admins = admins;
        }
    }
}
