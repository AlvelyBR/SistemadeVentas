using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Map(m => m.IdCountry).Name("CountryID");
            Map(m => m.NameCountry).Name("CountryName");
        }
    }
}
