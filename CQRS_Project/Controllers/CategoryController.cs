using CQRS_Project.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;

        public CategoryController(GetCategoryQueryHandler getCategoryQueryHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getCategoryQueryHandler.Handle();
            return View(values);
        }
    }
}
