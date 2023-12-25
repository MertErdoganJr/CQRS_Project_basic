namespace CQRS_Project.CQRSPattern.Commands
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
    }
}
