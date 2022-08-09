namespace EducationExApi.Data.DAL.CodeCoolDataRepositories.Interfaces
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {
        Task<Author> GetAuthorByIdAsync(int id);
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetAuthorWithTheMostMaterialsAsync();
    }
}
