using Azure;
using Microsoft.Data.SqlClient;
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
        public DbSet<TeacherModel> TeacherDbSet { get; set; }

        public StudentModel UpdateStudent(StudentModel student)
        {
            var sql = @"Update Students
SET FirstName = @pFirstName,
LastName = @pLastName,
MiddleName = @pMiddleName,
Age = @pAge,
ClassId = @pClassId
Where Id = @pId";
            var list = new List<SqlParameter> {
                new SqlParameter("@pFirstName", student.FirstName),
                new SqlParameter("@pLastName", student.LastName),
                new SqlParameter("@pMiddleName", student.MiddleName),
                new SqlParameter("@pAge", student.Age),
                new SqlParameter("@pClassId", student.ClassId),
                new SqlParameter("@pId", student.Id)};
            this.Database.ExecuteSqlRaw(sql, list);// отрпавляем запрос в БД с параметрами, после этой строки данные уже обновлены. 
            var sqlSelect = "Select * from Students where Id =" + student.Id;// возвращаем уже новую запись из БД
            var result = StudentDbSet.FromSqlRaw(sqlSelect).FirstOrDefault();
            return result;  
        }
        public TeacherModel UpdateTeacher(TeacherModel teacher)
        {
            var sql = @"Update Teachers
SET FirstName = @pFirstName,
LastName = @pLastName,
MiddleName = @pMiddleName,
Age = @pAge,
SubjectName = @SubjectName
Where Id = @pId";
        var list = new List<SqlParameter> {
                new SqlParameter("@pFirstName", teacher.FirstName),
                new SqlParameter("@pLastName", teacher.LastName),
                new SqlParameter("@pMiddleName", teacher.MiddleName),
                new SqlParameter("@pAge", teacher.Age),
                new SqlParameter("@Position", teacher.SubjectName),
                new SqlParameter("@pId", teacher.Id)};
            this.Database.ExecuteSqlRaw(sql, list);// отрпавляем запрос в БД с параметрами, после этой строки данные уже обновлены. 
            var sqlSelect = "Select * from Teachers where Id =" + teacher.Id;// возвращаем уже новую запись из БД
            var result = TeacherDbSet.FromSqlRaw(sqlSelect).FirstOrDefault();
            return result;
        }
        public Managment UpdateManagment(Managment managment)
        {
            var sql = @"Update Managment
SET FirstName = @pFirstName,
LastName = @pLastName,
MiddleName = @pMiddleName,
Age = @pAge,
Position = @Position
Where Id = @pId";
            var list = new List<SqlParameter> {
                new SqlParameter("@pFirstName", managment.FirstName),
                new SqlParameter("@pLastName", managment.LastName),
                new SqlParameter("@pMiddleName", managment.MiddleName),
                new SqlParameter("@pAge", managment.Age),
                new SqlParameter("@Position", managment.Position),
                new SqlParameter("@pId", managment.Id)};
            this.Database.ExecuteSqlRaw(sql, list);// отрпавляем запрос в БД с параметрами, после этой строки данные уже обновлены. 
            var sqlSelect = "Select * from Managment where Id =" + managment.Id;// возвращаем уже новую запись из БД
            var result = ManagmentsDbSet.FromSqlRaw(sqlSelect).FirstOrDefault();
            return result;
        }
    }
}
