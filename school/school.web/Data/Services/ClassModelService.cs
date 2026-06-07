using school.Db.Models;

namespace school.web.Data.Services
{
	public class ClassModelService
	{
		public List<ClassModel> classModels = new List<ClassModel>
		{
			new ClassModel { Id = 1, Number = 1 },
			new ClassModel { Id = 2, Number = 2 },
		};

		public List<ClassModel> GetClassModels()
		{
			return classModels;
		}
		
	}
}
