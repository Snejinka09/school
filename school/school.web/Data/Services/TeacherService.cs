using school.Db;
using school.Db.Models;
using school.web.PageModels;

namespace school.web.Data.Services
{
	public class TeacherService
	{
		private SchoolDbContext _context;
		public TeacherService(SchoolDbContext teacherService)
		{
			_context = teacherService;
		}
		public List<TeacherItemViewModel> GetTeachers()
		{
            var list = _context.TeacherDbSet.ToList();
			return list.ConvertAll(x => new TeacherItemViewModel(x));
        }
		public void Update(TeacherItemViewModel teacher)
		{
			/* var item = _context.TeacherDbSet.FirstOrDefault(x => x.Id == teacher.Id); */
/* 			if (item != null)
			{
				item.FirstName = teacher.FirstName;
				item.MiddleName = teacher.MiddleName;
				item.LastName = teacher.LastName;
				item.Age = teacher.Age;
				item.SubjectName = teacher.SubjectName; */
				var updateItem =
				_context.UpdateTeacher(teacher.Item);
			//}
		}
		private TeacherItemViewModel ConvertItem(TeacherModel x)
		{
			var item = new TeacherItemViewModel(x);
			return item;
		}
	}
}
