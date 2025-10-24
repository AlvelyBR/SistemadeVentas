
using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class OrderDetailMap : ClassMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            Map(m => m.OrderId).Name("OrderID");
            Map(m => m.ProductId).Name("ProductID");
            Map(m => m.Quantity).Name("Quantity");
            Map(m => m.TotalPrice).Name("TotalPrice");
        }
    }
}
