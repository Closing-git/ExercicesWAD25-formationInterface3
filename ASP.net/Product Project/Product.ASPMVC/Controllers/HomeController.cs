using Microsoft.AspNetCore.Mvc;
using Product.ASPMVC.Models;
using ProjectProduct.ASPMVC.Mapper;
using ProjectProduct.ASPMVC.Models.Product;
using ProjectProduct.Common.Repositories;
using System.Diagnostics;

namespace Product.ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository<ProjectProduct.BLL.Entities.Product> _bllService;

        public HomeController(IProductRepository<ProjectProduct.BLL.Entities.Product> bllService, ILogger<HomeController> logger)
        {
            _bllService = bllService;
            _logger = logger;
        }



        public IActionResult Index()
        {
            IEnumerable<ListItemViewModel> model;
            model = _bllService.Get().Select(bll => bll.ToListItem());
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
