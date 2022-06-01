using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace LabBigSchool_NguyenDuyHoangAnh.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Category> categories { get; set; }
        public object Categories { get; internal set; }

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