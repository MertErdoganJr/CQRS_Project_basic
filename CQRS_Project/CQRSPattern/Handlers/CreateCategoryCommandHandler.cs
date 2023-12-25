using CQRS_Project.CQRSPattern.Commands;
using CQRS_Project.DAL.Context;
using CQRS_Project.DAL.Entities;

namespace CQRS_Project.CQRSPattern.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public CreateCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
            });
            _context.SaveChanges();
        }
    }
}
