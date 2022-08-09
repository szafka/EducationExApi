﻿namespace EducationExApi.Data.DAL.CodeCoolDataRepositories.Interfaces
{
    public interface IMaterialRepository : IBaseRepository<Material>
    {
        Task<Material> GetElementByIdAsync(int id);
    }
}
