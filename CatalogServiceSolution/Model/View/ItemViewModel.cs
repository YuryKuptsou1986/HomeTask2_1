namespace Model.View
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri? Image { get; set; }
        public CategoryViewModel Category { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
