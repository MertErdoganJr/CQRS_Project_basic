using CQRS_Project.CQRSPattern.Commands;
using CQRS_Project.CQRSPattern.Handlers;
using CQRS_Project.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;

        public CategoryController(GetCategoryQueryHandler getCategoryQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getCategoryQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryCommand command)
        {
            _createCategoryCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return View(values);
        }
    }
}
