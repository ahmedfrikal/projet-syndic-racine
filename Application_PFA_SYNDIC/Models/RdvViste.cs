namespace Application_PFA_SYNDIC.Models
{
    public class RdvViste
    {
        public int Id { get; set; }
        public DateTime dateRdv { get; set; }
        public Lot lot { get; set; }
    }
}
