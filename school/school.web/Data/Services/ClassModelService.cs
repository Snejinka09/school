using school.Db;
using school.Db.Models;
using school.web.PageModels;

namespace school.web.Data.Services
{
	public class ClassModelService
	{
		private SchoolDbContext _context;
		public ClassModelService(SchoolDbContext schoolDbContext)
		{
			_context = schoolDbContext;
		}

        public List<ClassItemViewModel> GetClassModels()
		{
            var list = _context.ClassesModelDbSet.ToList();
            return list.ConvertAll(x => new ClassItemViewModel(x));
        }
		
	}
}
