using Eve.Domain;
using Microsoft.EntityFrameworkCore;

namespace Eve.Data
{
    public class EveDbSet:DbContext
    {
        public EveDbSet() { Database.EnsureCreated(); }

        public DbSet<Employe> employes { get; set; }
        public DbSet<Quittance> quittances { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=EverienceDB;
            Integrated Security=true;MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
