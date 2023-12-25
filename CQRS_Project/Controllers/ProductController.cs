using CQRS_Project.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;

        public ProductController(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
    }
}
