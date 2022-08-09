namespace EducationExApi.Data.DAL.CodeCoolDataRepositories.Interfaces
{
    public interface IMaterialRepository : IBaseRepository<Material>
    {
        Task<Material> GetByIdAsync(int id);
    }
}
