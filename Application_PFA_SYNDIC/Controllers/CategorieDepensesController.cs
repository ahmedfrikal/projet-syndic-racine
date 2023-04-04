using Application_PFA_SYNDIC.Models;
using Application_PFA_SYNDIC.ModelView.CategorieDepences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Application_PFA_SYNDIC.Controllers
{
    public class CategorieDepensesController : Controller
    {
        public Mycontext mycontext;
        public CategorieDepensesController(Mycontext context)
        {
            mycontext = context;
        }
        public IActionResult Index(int id)
        {
            id = 1;
            List<CategorieDepenses> categorieDepenses = mycontext.categorieDepenses.Where(e=>e.Id.Equals(id)).Include(m => m.depenses).ToList();
            return View(categorieDepenses);
        }
        public IActionResult Add()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Add(categorieDepencesView categorieDepencesView)
        {
            if (ModelState.IsValid)
            {
              CategorieDepenses categorieDepenses =new CategorieDepenses(categorieDepencesView,1);
              mycontext.categorieDepenses.Add(categorieDepenses);
              mycontext.SaveChanges();
              return RedirectToAction(nameof(Index));
            }
            return View();
           
        }

        public IActionResult delete(int id)
        {
            int nbrCategorieDepences = mycontext.depenses.Where(m => m.categorieDepensesid == id).Count();
            if (nbrCategorieDepences == 0)
            {
                CategorieDepenses categorieDepenses = mycontext.categorieDepenses.Find(id);
                mycontext.categorieDepenses.Remove(categorieDepenses);
                mycontext.SaveChangesAsync();

            }
            else
            {
                TempData["message"] = "Categorie est deja des depences";

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult edit(int id)
        {
            if (ModelState.IsValid)
            {
            CategorieDepenses categorieDepensesEdit = mycontext.categorieDepenses.Find(id);
            if (categorieDepensesEdit == null)
            {
                return NotFound();
            }
            categorieDepencesViewEdit categorieDepencesViewEdit = new categorieDepencesViewEdit(categorieDepensesEdit);
                  return View(categorieDepencesViewEdit);
            }
            return View();
        }
        [HttpPost]
        public IActionResult edit(categorieDepencesViewEdit categorieDepencesView)
        {

            if (ModelState.IsValid)
            {
                CategorieDepenses categorie = mycontext.categorieDepenses.Find(categorieDepencesView.id);
                categorie.rubrique = categorieDepencesView.Rubrique;
                mycontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
