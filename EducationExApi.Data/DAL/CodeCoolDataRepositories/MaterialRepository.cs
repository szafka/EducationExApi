namespace EducationExApi.Data.DAL.CodeCoolDataRepositories
{
    public class MaterialRepository : BaseRepository<Material>, IMaterialRepository
    {
        private readonly API_Context _context;

        public MaterialRepository(API_Context context) : base(context)
        {
            _context = context;
        }
        public async Task<Material> GetElementByIdAsync(int id) => await _context.Materials.Include(a => a.Author).Include(m => m.MaterialType).FirstOrDefaultAsync(a => a.MaterialId == id);
        public async Task<IEnumerable<Material>> GetAllMaterialsListAsync() => await _context.Materials.Include(a => a.Author).Include(m => m.MaterialType).ToListAsync();
        public IQueryable<Material> GetPaginatedListAllAsync() => _context.Materials.Include(a => a.Author).Include(m => m.MaterialType).AsQueryable();
        public override async Task<Material> AddAsync(Material material)
        {
            var addedElement = await _context.Set<Material>().AddAsync(material);
            int affectedRows = await _context.SaveChangesAsync();
            if (affectedRows == 1) return material;
            return null;
        }
    }
}
