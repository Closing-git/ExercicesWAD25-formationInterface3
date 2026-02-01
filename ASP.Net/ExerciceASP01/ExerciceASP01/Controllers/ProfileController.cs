using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceASP01.Controllers;
using Models.Profile;
public class ProfileController : Controller
{
    private static IEnumerable<EditForm> _profiles = [
        new EditForm(){
                Id=1,
                Nom = "Dupont",
                Prenom = "Pierre",
                Description = "ioeazrjaoeijaoerij oaierj aeoijra eoijreaoi reaoij aer",
                VilleDeResidence = "Paris"

            },
        new EditForm(){
                Id=2,
                Nom = "Auchan",
                Prenom = "Camille",
                VilleDeResidence = "Bruxelles",
            InscriptionNewsLetter = true,

            }
        ];

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("edit/{id}")]
    public IActionResult Edit(int id)
    {
        EditForm model = _profiles.SingleOrDefault(p => p.Id == id);
        return View(model);
    }


    [HttpPost("edit/{id}")]
    public IActionResult Edit(int id, EditForm form)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                throw new InvalidOperationException("Le model state n'est pas valide");


            }
            EditForm currentData = _profiles.SingleOrDefault(p => p.Id == id);
            currentData.Nom = form.Nom;
            currentData.Prenom = form.Prenom;
            currentData.VilleDeResidence = form.VilleDeResidence;
            currentData.InscriptionNewsLetter = form.InscriptionNewsLetter;
            TempData["message"] = "Vous avez édité votre profil";
            TempData["alert-type"] = "alert-success";
            return RedirectToAction("Index");
        }

        catch (Exception ex)
        {
            TempData["message"] = "Echec de l'édition";
            TempData["alert-type"] = "alert-warning";
            return View();
        }

    }
}

