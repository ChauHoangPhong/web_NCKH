using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Web_NCKH.Models.EF;

namespace Web_NCKH.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Phone { get; set; }   

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Achievements> Achievements { get; set; }
        public DbSet<AchievementsCategory> AchievementsCategories { get; set; }
        public DbSet<AchievementsDate> AchievementsDates { get; set; }
        public DbSet<Adv> Advs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LocationCategory> LocationCategories { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Recruitment> Recruitments { get; set; }
        public DbSet<TopicCategory> TopicCategories { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}