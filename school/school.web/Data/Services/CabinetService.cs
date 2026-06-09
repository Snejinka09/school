using school.Db;
using school.Db.Models;
using school.web.PageModels;

namespace school.web.Data.Services
{
    public class CabinetService
    {
       private SchoolDbContext _context;
       public CabinetService(SchoolDbContext schoolDbContext)
        {
            _context = schoolDbContext;
        }

        public List<CabinetItemViewModel> GetCabinets()
        {
            var list = _context.CabinetsDbSet.ToList();
            return list.ConvertAll(x => new CabinetItemViewModel(x));
        }
    }
}
