using school.Db.Models;

namespace school.web.Data.Services
{


	public class StudentService
    {
		List<Student> students = new List<Student>
		{
		new Student(2, "Maria", "Sergeevna", "Petrova", 18, 11),
		new Student(3, "Dmitry", "Alexandrovich", "Sidorov", 20, 12),
		new Student(4, "Elena", "Viktorovna", "Kozlova", 17, 10),
		new Student(5, "Nikita", "Igorevich", "Smirnov", 19, 11),
		};

        public List<Student> GetStudents()
        {
            return students;
        }
    }

}
