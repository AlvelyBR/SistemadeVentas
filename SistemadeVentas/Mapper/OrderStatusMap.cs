

using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class OrderStatusMap : ClassMap<OrderStatus>
    {
        public OrderStatusMap()
        {
            Map(m => m.IdStatus).Name("StatusID");
            Map(m => m.NameStatus).Name("StatusName");
        }
    }
}
