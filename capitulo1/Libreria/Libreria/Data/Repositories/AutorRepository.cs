namespace Libreria.Data.Repositories
{
    public class AutorRepository
    {
        private readonly AppDBContext _dbContext;

        public AutorRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }
    }
}
