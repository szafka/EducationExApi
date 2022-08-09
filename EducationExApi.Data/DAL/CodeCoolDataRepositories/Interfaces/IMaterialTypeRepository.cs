namespace EducationExApi.Data.DAL.CodeCoolDataRepositories.Interfaces
{
    public interface IMaterialTypeRepository : IBaseRepository<MaterialType>
    {
        Task<MaterialType> GetByIdAsync(int id);
    }
}
