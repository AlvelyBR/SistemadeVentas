

using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Map(m => m.IdOrder).Name("OrderID");
            Map(m => m.CustomerId).Name("CustomerID");
            Map(m => m.OrderDate).Name("OrderDate").TypeConverterOption.Format("yyyy-MM-dd");
            Map(m => m.StatusId).Name("Status");
        }
    }
}
