﻿namespace CartService.BLL.Entities
{
    public class CartDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ImageInfoDto ImageInfo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
