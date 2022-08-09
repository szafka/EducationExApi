namespace EducationExApi.Data.DAL.CodeCoolDataRepositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly API_Context _context;
        public AuthorRepository(API_Context context) : base(context)
        {
            _context = context;
        }

        public async Task<Author> GetAuthorByIdAsync(int id) => await _context.Authors.Include(m => m.Materials).FirstOrDefaultAsync(a => a.AuthorId == id);
        public async Task<Author> GetAuthorWithTheMostMaterialsAsync()
        {
            var sortedListOfAuthors = await _context.Authors.Include(m => m.Materials).OrderByDescending(m => m.Materials.Count()).ToListAsync();
            var authorWithTheMostMaterials = sortedListOfAuthors[0];
            return authorWithTheMostMaterials;
        }
    }
}
