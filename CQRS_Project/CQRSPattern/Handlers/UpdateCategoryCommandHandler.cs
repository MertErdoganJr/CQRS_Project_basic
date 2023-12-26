using CQRS_Project.CQRSPattern.Commands;
using CQRS_Project.DAL.Context;

namespace CQRS_Project.CQRSPattern.Handlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public UpdateCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public void Handler(UpdateCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryID);
            values.CategoryName = command.CategoryName;
            _context.SaveChanges();
        }
    }
}
