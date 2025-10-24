
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("products_category", Schema = "Ventas")]
    public class ProductCategory
    {
        [Key]
        [Column("idcategory")]
        public int IdCategory { get; set; }

        [MaxLength(100)]
        [Column("name_category")]
        public string NameCategory { get; set; }
    }
}
