
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemadeVentas.Modelos
{
    [Table("customers", Schema = "Ventas")]
    public class Customer
    {
        [Key]
        [Column("idcustomer")]
        public int IdCustomer { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("last_name")]
        public string LastName { get; set; }

        [MaxLength(100)]
        [Column("email")]
        public string Email { get; set; }

        [MaxLength(50)]
        [Column("phone")]
        public string Phone { get; set; }

        [Column("city")]
        public int? CityId { get; set; }

        [Column("country")]
        public int? CountryId { get; set; }

        // Relaciones
        public ICollection<Order> Orders { get; set; }
    }
}

