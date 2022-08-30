namespace EducationExApi.Data.DAL.CodeCoolDataRepositories.Interfaces
{
    public interface IMaterialRepository : IBaseRepository<Material>
    {
        Task<Material> GetElementByIdAsync(int id);
        Task<IEnumerable<Material>> GetAllMaterialsListAsync();
        IQueryable<Material> GetPaginatedListAllAsync();
    }
}
