using Microsoft.EntityFrameworkCore;
using Mobil_Market.Models;

namespace Mobile_Market.Models.DBwork
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> options) : base(options) 
        {

        }

        public DbSet<Order> orders { get; set; }

        public DbSet<Departement> departements { get; set; }
        
        public DbSet<Employee> employees { get; set; }
        
        public DbSet<Member> members { get; set; }
        
        public DbSet<orderDetials> orderDetials { get; set; }
        
        public DbSet<Product> products { get; set; }
        
        public DbSet<Mobil_Market.Models.SingInModel> SingInModel { get; set; } = default!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORM81DG;Initial Catalog=Suq_Com;Integrated Security=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // add this:
            modelBuilder.Entity<Member>().Property(p => p.memberId).ValueGeneratedOnAdd();
        }
    }
}
