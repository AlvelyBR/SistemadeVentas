using Microsoft.EntityFrameworkCore;
using SistemadeVentas.Context;
using SistemadeVentas.Servicios;

class Program
{
    static void Main(string[] args)
    {
        var connectionString = Environment.GetEnvironmentVariable("ConnectionString");

        if (string.IsNullOrEmpty(connectionString))
        {
            Console.WriteLine("❌ No se encontró la cadena de conexión en las variables de entorno.");
            return;
        }

        var dbService = new DbLoaderService(connectionString);
        dbService.ProbarConexion();

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(connectionString);

        using var context = new AppDbContext(optionsBuilder.Options);

        try
        {
            context.Database.OpenConnection();
            Console.WriteLine("✅ AppDbContext está conectado correctamente.");
            context.Database.CloseConnection();
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error usando AppDbContext: " + ex.Message);
        }

        //Servies de ETL
        var etlService = new EtlService(context);

        etlService.LoadCsvToDb<SistemadeVentas.Modelos.Customer>("C:\\Programas\\Ventas\\SistemadeVentas\\Datos\\customers.csv");
        etlService.LoadCsvToDb<SistemadeVentas.Modelos.Product>("C:\\Programas\\Ventas\\SistemadeVentas\\Datos\\products.csv");
        etlService.LoadCsvToDb<SistemadeVentas.Modelos.Order>("C:\\Programas\\Ventas\\SistemadeVentas\\Datos\\orders.csv");
        etlService.LoadCsvToDb<SistemadeVentas.Modelos.OrderDetail>("C:\\Programas\\Ventas\\SistemadeVentas\\Datos\\order_details.csv");



        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}
