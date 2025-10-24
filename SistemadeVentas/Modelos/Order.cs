

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("orders", Schema = "Ventas")]
    public class Order
    {
        [Key]
        [Column("idorder")]
        public int IdOrder { get; set; }

        [Column("customer")]
        public int? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Column("status")]
        public int? StatusId { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
