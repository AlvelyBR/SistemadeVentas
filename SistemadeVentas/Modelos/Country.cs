

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("country", Schema = "Ventas")]
    public class Country
    {
        [Key]
        [Column("idcountry")]
        public int IdCountry { get; set; }

        [MaxLength(100)]
        [Column("name_country")]
        public string NameCountry { get; set; }
    }
}
