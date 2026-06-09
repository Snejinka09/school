using school.Db;
using school.Db.Models;

namespace school.web.Data.Services
{


	public class StudentService
    {
		private SchoolDbContext _context; //переменная, чтобы приянть schoolDbContext

        public StudentService(SchoolDbContext schoolDbContext) // конструктор для подключения БД
		{
			_context = schoolDbContext;
		}
		public List<StudentItemViewModel> GetStudents()
		{
			var list = _context.StudentDbSet.ToList();
			return list.ConvertAll(x => ConvertItem(x));
		}

        private StudentItemViewModel ConvertItem(StudentModel x)
        {
			var item = new StudentItemViewModel(x);
			return item;

        }
    }

}
