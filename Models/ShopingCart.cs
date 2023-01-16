using System.ComponentModel.DataAnnotations.Schema;

namespace WebCandleShopNet7.Models
{
    [Table("ShopingCart")]
    public class ShopingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }=false;
    }
}
