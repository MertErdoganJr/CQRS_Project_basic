using CQRS_Project.CQRSPattern.Commands;
using CQRS_Project.DAL.Context;
using CQRS_Project.DAL.Entities;

namespace CQRS_Project.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly SaleContext _context;

        public CreateProductCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                CategoryID = command.CategoryID,
                ProductName = command.ProductName,
                Price = command.Price,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
