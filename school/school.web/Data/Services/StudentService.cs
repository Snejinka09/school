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

		public void Update(StudentItemViewModel student)
		{
			//var item = _context.StudentDbSet.FirstOrDefault(x => x.Id == student.Id);
			//if (item != null)
			//{
			//	item.FirstName = student.FirstName;
			//	item.LastName = student.LastName;
			//	item.Age = student.Age;
			//	item.MiddleName = student.MiddleName;
				var updateItem = _context.UpdateStudent(student.Item);
			//}
		}
       

        private StudentItemViewModel ConvertItem(StudentModel x)
        {
			var item = new StudentItemViewModel(x);
			return item;
        }
    }

}
