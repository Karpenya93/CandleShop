using System.ComponentModel.DataAnnotations.Schema;

namespace WebCandleShopNet7.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; }= DateTime.Now;
        public int OrderStatusId { get; set; } 
        public bool IsDeleted { get; set; }= false;
        public  StatusOrder StatusOrder { get; set; }
        public List<DetailOrder> DetailOrder { get; set; }

    }
}
