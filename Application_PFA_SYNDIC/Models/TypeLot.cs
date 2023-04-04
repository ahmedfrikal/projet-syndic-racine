namespace Application_PFA_SYNDIC.Models
{
    public class TypeLot
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public  List<Lot> Lots { get; set; }
    }
}
