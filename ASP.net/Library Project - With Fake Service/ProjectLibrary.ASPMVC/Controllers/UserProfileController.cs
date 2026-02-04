using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibrary.ASPMVC.Mappers;
using ProjectLibrary.ASPMVC.Models.UserProfile;
using ProjectLibrary.BLL.Entities;
using ProjectLibrary.Common.Repositories;


namespace ProjectLibrary.ASPMVC.Controllers
{
    public class UserProfileController : Controller
    {
        //Injection de la dépendance du service BLL
        private readonly IUserProfileRepository<BLL.Entities.UserProfile> _bllService;

        public UserProfileController(IUserProfileRepository<BLL.Entities.UserProfile> bllService)
        {
            _bllService = bllService;
        }

        // GET: UserProfileController
        public ActionResult Index()
        {
            IEnumerable<ListItemViewModel> model;
            model = _bllService.Get().Select(bll => bll.ToListItem());
            return View(model);
        }

        // GET: UserProfileController/Details/5
        public ActionResult Details(Guid id)
        {
            DetailsViewModel model = _bllService.Get(id).ToDetails();
            return View(model);
        }

        // GET: UserProfileController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserProfileController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.UserProfile.CreateForm form)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new InvalidOperationException("Le formulaire n'est pas valide");
                }
                Guid userProfileId = _bllService.Create(form.ToBLL());
                return RedirectToAction(nameof(Edit), "UserProfile", new {id = userProfileId});
            }
            catch
            {
                return View();
            }
        }

        // GET: UserProfileController/Edit/5
        public ActionResult Edit(Guid id)
        {
            UserProfile data = _bllService.Get(id);
            EditForm model = data.ToEdit();
            //POSSIBILITE 1 POUR OBTENIR DES DONNES DANS LA PAGE
            //ViewData["nom"] = data.LastName;
            //ViewData["prenom"] = data.FirstName;

            //POSSIBILITE 2 POUR OBTENIR DES DONNES DANS LA PAGE (mettre en place une dépendance directement dans la vue)



            return View(model);
        }

        // POST: UserProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, EditForm form)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new InvalidOperationException("Le formulaire n'est pas valide");
                }
                _bllService.Update(id, form.ToBLL());

                return RedirectToAction(nameof(Details), "UserProfile", new { id = id});
            }
            catch
            {
                return View();
            }
        }

        // GET: UserProfileController/Delete/5
        public ActionResult Delete(Guid id)
        {
            DeleteViewModel model = _bllService.Get(id).ToDelete();
            return View(model);
        }

        // POST: UserProfileController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                _bllService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
