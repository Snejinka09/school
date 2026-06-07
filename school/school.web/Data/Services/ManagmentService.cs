using school.Db.Models;

namespace school.web.Data.Services
{
	public class ManagmentService
	{
		List<Managment> managments = new List<Managment>
		{
			new Managment {Id = 1, Position = "Director", FirstName = "Alla", MiddleName = "Borisovna", Age = 45, LastName = "Ivanova" },
			new Managment {Id = 2,Position = "Zavuch", FirstName = "Anna", MiddleName = "Georgievna", Age = 39, LastName = "Bobrova" },
		};
		public List<Managment> GetManagments()
		{
			return managments;
		}
	}
}
