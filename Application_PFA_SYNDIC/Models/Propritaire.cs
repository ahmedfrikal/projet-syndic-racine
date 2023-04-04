namespace Application_PFA_SYNDIC.Models
{
    public class Propritaire : User
    {
        public string nomPerssoneCasUrgence { get; set; }
        public string prenomPerssoneCasUrgence { get; set; }
        public string contactPerssoneCasUrgence { get; set; }
        public List<reunion> reunions { get; set; }

    }
}
