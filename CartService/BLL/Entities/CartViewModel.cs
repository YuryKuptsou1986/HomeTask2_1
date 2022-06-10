namespace CartService.BLL.Entities
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ImageInfoViewModel ImageInfo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
