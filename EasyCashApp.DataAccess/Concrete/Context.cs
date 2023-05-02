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
    public class Context : IdentityDbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {// Configuration kismini appsettings.json icerisinde de yazabiliriz.
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=ALBATROS46;Database=EasyCashDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=yes;");//Kendi veritabani erisiminizi yaziniz
        }

        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountsProcess { get; set; }

    }
}
  //"ConnectionStrings": {
  //  "DefaultConnection": "Server=ALBATROS46;Database=SchoolProject.Web;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=yes;"
  //}