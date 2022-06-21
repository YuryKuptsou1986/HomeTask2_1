namespace Model.View
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri? Image { get; set; }
        public CategoryViewModel? ParentCategory { get; set; }
    }
}
