namespace Application_PFA_SYNDIC.Models
{
    public class Lot
    {
        public int Id { get; set; }
        public string mumero { get; set; }
        public string etage { get; set; }
        public bool disponibilte { get; set; }
        public DateTime dateAquisition { get; set; }
        public float prixLocation { get; set; }
        public float prixVente { get; set; }
        public string desciption { get; set; }
        public int superficie { get; set; }
        public int typeLotId { get; set; }
        public TypeLot typeLot { get; set; }
        public List<Avis> avis { get; set; } 
        public List<RdvViste> rdvvistes { get; set; }
        public List<ImageLots> imageLots { get; set; }
        public List<Louer> louers { get; set; }
    }
}
