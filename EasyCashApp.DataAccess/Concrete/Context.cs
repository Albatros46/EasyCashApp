using EasyCashApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.DataAccess.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {// Configuration kismini appsettings.json icerisinde de yazabiliriz.
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=ALBATROS46;Database=EasyCashDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=yes;");//Kendi veritabani erisiminizi yaziniz
        }

        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountsProcess { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {//Iliskili tablolarda birbirinden veri aktarimi yaparken veya veri tuttarken kullanilacak
            builder.Entity<CustomerAccountProcess>()
                .HasOne(x=>x.SenderCustomer)
                .WithMany(y=>y.CustomerSender)
                .HasForeignKey(z=>z.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<CustomerAccountProcess>()
              .HasOne(x => x.ReceiverCustomer)
              .WithMany(y => y.CustomerReceiver)
              .HasForeignKey(z => z.ReceiverId)
              .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);//migration a müdahale edildigi icin bu satir olmaz ise hata verir.
        }

    }
}
  //"ConnectionStrings": {
  //  "DefaultConnection": "Server=ALBATROS46;Database=SchoolProject.Web;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=yes;"
  //}