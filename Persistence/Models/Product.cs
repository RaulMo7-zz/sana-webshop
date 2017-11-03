using System.ComponentModel.DataAnnotations;

namespace Persistence.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string Number { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
