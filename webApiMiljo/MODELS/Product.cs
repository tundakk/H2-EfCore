using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApiMiljo.MODELS
{
    public class Product
    {
        public Product()
        {
        }
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public Decimal? Price { get; set; }
        public DateTime? CreatedDate { get; set; }

        //navigational property
        public ICollection<Order> Orders { get; set; }
    }
}
