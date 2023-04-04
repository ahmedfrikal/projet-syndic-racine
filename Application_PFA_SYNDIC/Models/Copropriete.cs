using System.ComponentModel.DataAnnotations;

namespace Application_PFA_SYNDIC.Models
{
    public class Copropriete
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string ville { get; set;}
        public string adresse { get; set;}
        public string codePostal { get; set;}
        public DateTime dateDebutExercise { get; set;}
        [MinLength(0, ErrorMessage = "Le nbr de lot doit etre superiere a 0")]
        public int nbrLots { get; set; }
        public float budgetAnnuel { get; set; }
        public List<CategorieDepenses> categorieDepenses { get; set; }
        public List<Lot> lots { get; set; }
        public List<reunion> reunions { get; set; }

    }
}
