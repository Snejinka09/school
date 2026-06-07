using school.Db.Models;

namespace school.web.Data.Services
{
    public class CabinetService
    {
        private List<Cabinet> cabinets = new List<Cabinet>
        {
            new Cabinet{ Id = 1, Number = 21},
            new Cabinet{ Id = 2, Number = 22},
        };

        public List<Cabinet> GetCabinets()
        {
            return cabinets;
        }
    }
}
