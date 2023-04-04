namespace Application_PFA_SYNDIC.Models
{
    public class Louer
    {
        public int Id { get; set; }
        public float Montant { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public int lotId { get; set; }
        public Lot lot { get; set; }
        public int propritaireId { get;set; }
        public Propritaire propritaire { get; set; }
        public etatDeLieu etatDeLieu { get; set; }
        public List<paiement> paiements { get; set; }
    }
}
