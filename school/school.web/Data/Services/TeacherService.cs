using school.Db.Models;

namespace school.web.Data.Services
{
	public class TeacherService
	{
		public List<Teacher> teachers = new List<Teacher>
		{
			new Teacher {Id = 1, FirstName = "Snejana", MiddleName = "Denisovna", LastName = "Tarasova", Age = 37},
			new Teacher {Id = 2, FirstName = "Polina", MiddleName = "Nikiforovna", LastName = "Strokotova", Age= 22}
		};	
		public List<Teacher> GetTeachers()
		{
			return teachers;
		}
	}
}
