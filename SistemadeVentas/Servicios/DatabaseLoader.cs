using SistemadeVentas.Context;


namespace SistemadeVentas.Servicios
{
    public class DatabaseLoader
    {
        private readonly AppDbContext _context;

        public DatabaseLoader(AppDbContext context)
        {
            _context = context;
        }

        public void InsertEntities<T>(List<T> entities) where T : class
        {
            if (entities == null || entities.Count == 0) return;

            _context.Set<T>().AddRange(entities);
            _context.SaveChanges();
        }
    }
}
