using CQRS_Project.CQRSPattern.Commands;
using CQRS_Project.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(CreateProductCommandHandler createProductCommandHandler, GetProductQueryHandler getProductQueryHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _getProductQueryHandler = getProductQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProduct() { return View(); }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
