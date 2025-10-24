

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("city", Schema = "Ventas")]
    public class City
    {
        [Key]
        [Column("idcity")]
        public int IdCity { get; set; }

        [MaxLength(100)]
        [Column("name_city")]
        public string NameCity { get; set; }
    }
}
