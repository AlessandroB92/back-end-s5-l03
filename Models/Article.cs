namespace back_end_s5_l03.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public List<string> AdditionalImages { get; set; }
        public bool IsDisplayedOnHomePage { get; set; }
    }
}
