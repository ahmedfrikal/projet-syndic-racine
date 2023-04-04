namespace Application_PFA_SYNDIC.Models
{
    public class paiement
    {
        public int Id { get; set; }
        public DateTime dateDencaisement { get; set; }
        public string commentaire { get;set; }
        public float montantEncaiser { get; set; }
        public string justificative { get; set; }
        public int numerotrasaction { get; set; }
    }
}
