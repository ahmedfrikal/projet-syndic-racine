using Microsoft.EntityFrameworkCore;

namespace Application_PFA_SYNDIC.Models
{
    public class Mycontext : DbContext
    {
        public DbSet<Copropriete> coproprietes { get; set; }
        public DbSet<Lot> lots { get; set; }
        public DbSet<RdvViste> rdvVistes { get; set; }
        public DbSet<Avis> avis { get; set; }
        public DbSet<TypeLot> typeLots { get; set; }
        public DbSet<ImageLots> imageLots { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<Louer> louers { get; set; }
        public DbSet<etatDeLieu> etatDeLieus { get; set; }
        public DbSet<paiement> paiements { get; set; }
        public DbSet<Propritaire> propritaires { get; set; }
        public DbSet<reunion> reunions { get; set; }
        public DbSet<Syndic> syndics { get; set; }
        public DbSet<Admin> amins { get; set; }
        public DbSet<CategorieDepenses> categorieDepenses { get; set; }
        public DbSet<Depense> depenses { get; set; }
        public Mycontext(DbContextOptions<Mycontext> opt) : base(opt)
        {

        }
    }
}
