using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using ProjectLibrary.ASPMVC.Mappers;
using ProjectLibrary.ASPMVC.Models.Auth;
using ProjectLibrary.BLL.Entities;
using ProjectLibrary.Common.Repositories;

namespace ProjectLibrary.ASPMVC.Controllers
{
    public class AuthController : Controller
    {
        //On le créé Vide vu qu'il le CRUD ne s'applique pas

        private readonly IUserRepository<BLL.Entities.User> _bllService;

        public AuthController(IUserRepository<User> bllService)
        {
            _bllService = bllService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterForm form)
        {
            try
            {
                if (form.AgreeTerms == false) ModelState.AddModelError(nameof(form.AgreeTerms), "Vous devez accepter les conditions");
                if (!ModelState.IsValid) throw new InvalidOperationException("Le formulaire n'est pas valide");
                Guid userId = _bllService.Create(form.ToBLL());
                return RedirectToAction("Login");

            }
            catch (Exception ex)
            {
                return View();
            }
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new InvalidOperationException("Le formulaire n'est pas valide");
                Guid userId = _bllService.CheckPassword(form.Email, form.Password);
                return RedirectToAction("Index", "Home");

            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}
