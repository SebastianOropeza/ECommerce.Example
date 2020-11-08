namespace ECommerce.API.Dtos
{
    public class CartItemDto
    {
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}