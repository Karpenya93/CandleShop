using System.ComponentModel.DataAnnotations.Schema;

namespace WebCandleShopNet7.Models
{
    [Table("DetailOrder")]
    public class DetailOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CandleId { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public Order Order { get; set; }
        public Candle Candle { get; set; }
    }
}
