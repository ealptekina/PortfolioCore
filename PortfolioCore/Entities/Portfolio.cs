namespace PortfolioCore.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Client { get; set; }
        public string ProjectDate { get; set; }
        public string ProjectUrl { get; set; }
        public string ProjectName { get; set; }
        public string Title { get; set; }
        public string DetailDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
