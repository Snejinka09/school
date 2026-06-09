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
	}
}
