using System;

namespace CartService.Domain.Entities
{
    public class Cart
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public ImageInfo ImageInfo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        private Cart()
        {

        }

        public Cart(string name, decimal price, int quantity, ImageInfo imageInfo = null)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            ImageInfo = imageInfo;
        }
    }
}
