using Microsoft.EntityFrameworkCore;
using school.Db;
using school.Db.Models;

namespace school.web.Data.Services
{
	public class ManagmentService
	{
		private SchoolDbContext _context;
		public ManagmentService(SchoolDbContext schoolDbContext)
        {
            _context = schoolDbContext;
        }

        public List<ManagmentItemViewModel> GetManagments()
		{
            var list = _context.ManagmentsDbSet.ToList();
            return list.ConvertAll(x => new ManagmentItemViewModel(x));

        }
	}
}
