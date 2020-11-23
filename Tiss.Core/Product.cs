using System.ComponentModel.DataAnnotations;

namespace Tiss.Core
{
    public class Product : ApplicationEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
