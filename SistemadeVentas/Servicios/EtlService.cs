using SistemadeVentas.Context;

namespace SistemadeVentas.Servicios
{
    public class EtlService
    {
        private readonly AppDbContext _context;

        public EtlService(AppDbContext context)
        {
            _context = context;
        }

        public void LoadCsvToDb<T>(string csvFilePath) where T : class
        {
            var csvLoader = new CsvLoader();
            var databaseLoader = new DatabaseLoader(_context);

            var records = csvLoader.ReadCsv<T>(csvFilePath);
            databaseLoader.InsertEntities(records);

            Console.WriteLine($"✔ Se cargaron {records.Count} registros de {typeof(T).Name} desde {csvFilePath}");
        }
    }
}
