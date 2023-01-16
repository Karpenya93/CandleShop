using System.ComponentModel.DataAnnotations;

namespace WebCandleShopNet7.Models
{
    public class StatusOrder
    {
        public int Id { get; set; }
        [Required]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
