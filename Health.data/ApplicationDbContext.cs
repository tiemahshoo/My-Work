using Health.data.model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<User> User { get; set; }
        public DbSet<Totals> Total { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<Meal_User> Meal_User { get; set; }
        public DbSet<Percents> Percents { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}