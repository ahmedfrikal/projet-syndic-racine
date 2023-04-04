namespace Application_PFA_SYNDIC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string civilité { get; set; }
        public string nom { get; set; }
        public string prenom { get;set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string adress { get; set; }
    }
}
