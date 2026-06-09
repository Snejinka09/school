using school.Db;
using school.Db.Models;

namespace school.web.Data.Services
{
    public class ScheduleService
    {
        private SchoolDbContext _context;
        public ScheduleService(SchoolDbContext context)
        {
            _context = context;
        }

        public List<ScheduleItemViewModel> GetSchedules()
        {
            var list = _context.ScheduleDbSet.ToList();
            return list.ConvertAll(x => new ScheduleItemViewModel(x));
        }
    }
}
