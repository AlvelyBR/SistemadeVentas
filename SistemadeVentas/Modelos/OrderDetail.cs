

using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("order_details", Schema = "Ventas")]
    public class OrderDetail
    {
        [Column("order")]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Column("product")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("total_price")]
        public decimal TotalPrice { get; set; }
    }
}
