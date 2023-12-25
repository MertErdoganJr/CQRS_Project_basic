using CQRS_Project.CQRSPattern.Results;
using CQRS_Project.DAL.Context;

namespace CQRS_Project.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly SaleContext _context;

        public GetProductQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Price = x.Price,
                ProductName = x.ProductName,
                ProductID = x.ProductID,
                CategoryID = x.CategoryID,
                Stock = x.Stock,
            }).ToList();
            return values;
        }
    }
}
