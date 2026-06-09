using Microsoft.EntityFrameworkCore;
using school.Db.Models;

namespace school.Db
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<StudentModel> StudentDbSet { get; set; }
        public DbSet<Cabinet> CabinetsDbSet { get; set; }
        public DbSet<ClassModel> ClassesModelDbSet { get; set; }
        public DbSet<Managment> ManagmentsDbSet { get; set; }
        public DbSet<ScheduleModel> ScheduleDbSet { get; set; }
        public DbSet<TeacherModel> TeacherDbSet { get;set; }
    }
}
