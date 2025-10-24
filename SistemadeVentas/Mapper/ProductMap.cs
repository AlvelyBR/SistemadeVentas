using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Map(m => m.IdProduct).Name("ProductID");
            Map(m => m.ProductName).Name("ProductName");
            Map(m => m.Price).Name("Price");
            Map(m => m.Stock).Name("Stock");
            Map(m => m.CategoryId).Name("Category");
        }
    }
}
