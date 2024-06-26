using BeautyApp.Entity.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.DataAccess.Context
{
    public class BeautyAppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public BeautyAppDbContext(DbContextOptions<BeautyAppDbContext> options):base(options) 
        {
            
        }


        DbSet<Deneme> Denemes { get; set; }
    }
}
