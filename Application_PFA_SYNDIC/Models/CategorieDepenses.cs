using Application_PFA_SYNDIC.ModelView.CategorieDepences;


namespace Application_PFA_SYNDIC.Models
{
    public class CategorieDepenses
    {
        public int Id { get; set; }
        public string rubrique { get; set; }
        public int coproprieteId { get; set; }
        public Copropriete copropriete { get; set; }
        public List<Depense> depenses { get; set; }

        public CategorieDepenses() { }
        public CategorieDepenses(categorieDepencesView categoriesDepencesView,int coproprieteId)
        {
            rubrique= categoriesDepencesView.rubrique;
            this.coproprieteId=coproprieteId;
        }
        public CategorieDepenses(categorieDepencesViewEdit categorieDepencesViewEdit)
        {
            Id = categorieDepencesViewEdit.id;
            rubrique = categorieDepencesViewEdit.Rubrique;
        }
         
    }
}
