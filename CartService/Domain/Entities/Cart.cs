using System;

namespace CartService.Domain.Entities
{
    public class Cart
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public ImageInfo ImageInfo { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        private Cart()
        {

        }

        public Cart(string name, decimal price, int quantity, ImageInfo imageInfo = null)
        {
            UpdateName(name);
            UpdatePrice(price);
            UpdateQuantity(quantity);
            UpdateImageInfo(imageInfo);
        }

        public void UpdateImageInfo(ImageInfo imageInfo)
        {
            ImageInfo = imageInfo;
        }

        public void UpdateName(string name)
        {
            if (string.IsNullOrEmpty(name)) {
                throw new ArgumentException("Can not be null or empty", nameof(Name));
            }
            Name = name;
        }

        public void UpdateQuantity(int quantity)
        {
            if (quantity < 0) {
                throw new ArgumentException("Should be greater 0", nameof(Price));
            }
            Quantity = quantity;
        }

        public void UpdatePrice(decimal price)
        {
            if (price < 0) {
                throw new ArgumentException("Should be greater 0", nameof(Price));
            }
            Price = price;
        }
    }
}
