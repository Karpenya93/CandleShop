namespace WebCandleShopNet7.Models
{
    public class CartDetail
    {
        public int Id { get; set; }
        public int ShoppingCart_Id { get; set; }
        public int CandleId { get; set; }
        public int Quantity { get; set; }
        public Candle Candle { get; set; }
        public ShopingCart ShopingCart { get; set; }
    }
}
