namespace Application_PFA_SYNDIC.Models
{
    public class etatDeLieu
    {
        public int Id { get; set; }
        public string libelle { get; set; }  
        public int nbrElement { get;set; }  
        public int louerId { get; set; }
        public Louer louer { get; set; }
        public List<ImageEtatLieu> imageEtatLieus { get; set; }

    }
}
