namespace Application_PFA_SYNDIC.Models
{
    public class Depense
    {
        public int Id { get; set; }
        public string libelle { get; set; }
        public float budget { get; set; }
        public DateTime dateDepense { get; set; }
        public int categorieDepensesid { get; set; }
        public CategorieDepenses categorieDepenses { get; set; }

    }
}
