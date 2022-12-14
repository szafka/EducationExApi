namespace EducationExApi.Data.DAL.CodeCoolDataRepositories
{
    public class MaterialTypeRepository : BaseRepository<MaterialType>, IMaterialTypeRepository
    {
        private readonly API_Context _context;

        public MaterialTypeRepository(API_Context context) : base(context)
        {
            _context = context;
        }

        public async Task<MaterialType> GetByIdAsync(int id) => await _context.MaterialTypes.Include(m => m.Materials).FirstOrDefaultAsync(a => a.Id == id);
    }
}
