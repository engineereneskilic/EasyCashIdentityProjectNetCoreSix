using EasyCashIdentityProjectNetCoreSix.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.DataAccessLayer.Concrete
{   //IdentityDbContext<AppUser,AppRole,int>
    public class Context: IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HDU6E5A;initial catalog=EasyCashDB; integrated Security=true;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;");
            // MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;
        }

        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
    }
}
