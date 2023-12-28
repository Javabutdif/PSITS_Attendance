using Microsoft.EntityFrameworkCore;
using PSITS_Attendance.Models;

namespace PSITS_Attendance.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AdminData> administrative { get; set; }
    }
}
