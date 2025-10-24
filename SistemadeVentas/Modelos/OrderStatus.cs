
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("order_status", Schema = "Ventas")]
    public class OrderStatus
    {
        [Key]
        [Column("idstatus")]
        public int IdStatus { get; set; }

        [Column("name_status")]
        public string NameStatus { get; set; }
    }
}
