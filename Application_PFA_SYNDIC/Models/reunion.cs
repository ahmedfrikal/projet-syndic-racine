namespace Application_PFA_SYNDIC.Models
{
    public class reunion
    {
        public int Id { get; set; }
        public DateTime dateReunion { get; set; }
        public string emplacement { get; set; }
        public Propritaire propritaire { get; set; }
        public Copropriete Copropriete { get; set; }
    }
}
