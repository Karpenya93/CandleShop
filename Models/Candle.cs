using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCandleShopNet7.Models
{
    [Table("Candle")]
    public class Candle
    {
     
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<DetailOrder> DetailOrder { get; set; }
        public List<CartDetail> CartDetail { get; set; }

    }
}
