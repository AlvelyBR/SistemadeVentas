

using CsvHelper.Configuration;
using SistemadeVentas.Modelos;

namespace SistemadeVentas.Mapper
{
    public sealed class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Map(m => m.IdCustomer).Name("CustomerID");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.LastName).Name("LastName");
            Map(m => m.Email).Name("Email");
            Map(m => m.Phone).Name("Phone");
            Map(m => m.CityId).Name("City");
            Map(m => m.CountryId).Name("Country");
        }
    }
}
