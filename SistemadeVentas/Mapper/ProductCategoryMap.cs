
using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class ProductCategoryMap : ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            Map(m => m.IdCategory).Name("CategoryID");
            Map(m => m.NameCategory).Name("CategoryName");
        }
    }
}
