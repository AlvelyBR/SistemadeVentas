

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("products", Schema = "Ventas")]
    public class Product
    {
        [Key]
        [Column("idproducts")]
        public int IdProduct { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("product_name")]
        public string ProductName { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("stock")]
        public int Stock { get; set; }

        [Column("category")]
        public int? CategoryId { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
