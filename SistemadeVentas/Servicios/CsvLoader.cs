using CsvHelper;
using CsvHelper.Configuration;
using SistemadeVentas.Mapper;
using SistemadeVentas.Modelos;
using System.Globalization;

namespace SistemadeVentas.Servicios
{
    public class CsvLoader
    {
        public List<T> ReadCsv<T>(string filePath) where T : class
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Archivo no encontrado: {filePath}");

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null
            });

            // Registrar ClassMap según el tipo
            if (typeof(T) == typeof(Customer)) csv.Context.RegisterClassMap<CustomerMap>();
            else if (typeof(T) == typeof(Product)) csv.Context.RegisterClassMap<ProductMap>();
            else if (typeof(T) == typeof(Order)) csv.Context.RegisterClassMap<OrderMap>();
            else if (typeof(T) == typeof(OrderDetail)) csv.Context.RegisterClassMap<OrderDetailMap>();
            else if (typeof(T) == typeof(City)) csv.Context.RegisterClassMap<CityMap>();
            else if (typeof(T) == typeof(Country)) csv.Context.RegisterClassMap<CountryMap>();
            else if (typeof(T) == typeof(ProductCategory)) csv.Context.RegisterClassMap<ProductCategoryMap>();
            else if (typeof(T) == typeof(OrderStatus)) csv.Context.RegisterClassMap<OrderStatusMap>();

            var records = csv.GetRecords<T>();
            return new List<T>(records);
        }
    }
}
