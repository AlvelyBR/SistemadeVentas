
using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Map(m => m.IdCity).Name("CityID");
            Map(m => m.NameCity).Name("CityName");
        }
    }
}
