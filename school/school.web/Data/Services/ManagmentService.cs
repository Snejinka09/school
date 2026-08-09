using Microsoft.EntityFrameworkCore;
using school.Db;
using school.Db.Models;
using school.web.PageModels.Managments;
using school.web.PageModels.Students;

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
        public void AddManagment(ManagmentItemViewModel managment)
        {
            _context.ManagmentsDbSet.Add(managment.Item);
            _context.SaveChanges();
        }

        public void RemoveManagment(ManagmentItemViewModel managment)
        {
            var removeItem = _context.ManagmentsDbSet.FirstOrDefault(x => x.Id == managment.Id);
            if (removeItem != null)
            {
                _context.ManagmentsDbSet.Remove(removeItem);
                _context.SaveChanges();
            }
        }

        public void Update(ManagmentItemViewModel managment)
        {
            //var item = _context.StudentDbSet.FirstOrDefault(x => x.Id == student.Id);
            //if (item != null)
            //{
            //	item.FirstName = student.FirstName;
            //	item.LastName = student.LastName;
            //	item.Age = student.Age;
            //	item.MiddleName = student.MiddleName;
            var updateItem = _context.UpdateManagment(managment.Item);
            //}
        }
    }
}
