using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{

    public class CabinetItemViewModel
    {
        public Cabinet Item => _item;
        private Cabinet _item;
        public CabinetItemViewModel(Cabinet item)
        {
            item = _item;
        }

        public int Id { get => _item.Id; set => _item.Id = value; }

        public int Number { get => _item.Number ; set => _item.Number = value; }

        public int? TeacherId { get => _item.TeacherId ; set => _item.TeacherId = value; }
        //public Teacher Teacher { get; set; }
    }
}
