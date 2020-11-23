using System.ComponentModel.DataAnnotations;

namespace Tiss.Web.Models
{
    public class ProductViewModel
    {
        [Display(Name = "Артикул")]
        public int Id { get; set; }
        [Display(Name = "Количество")]
        public int Count { get; set; }
        [Display(Name = "Цена")]
        public double Price { get; set; }
    }
}