using Application_PFA_SYNDIC.Models;

namespace Application_PFA_SYNDIC.ModelView.CategorieDepences
{
    public class categorieDepencesViewEdit
    {
        public int id { get;set; }
        public string Rubrique { get;set; }
        public categorieDepencesViewEdit() { }
        public categorieDepencesViewEdit(CategorieDepenses categorieDepences) 
        {
            id=categorieDepences.Id;
            Rubrique = categorieDepences.rubrique;
        
        }
    }
}
