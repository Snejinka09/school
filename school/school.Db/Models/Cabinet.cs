using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{

    //    <summary>
    //    Кабинеты
    //    </summary>
    public class Cabinet
    {

        //    <summary>
        //    id кабинета
        //    </summary>
        public int Id { get; set; }

        //    <summary>
        //    Номер
        //    </summary>
        public int Number { get; set; }

        //    <summary>
        //    id предмета
        //    </summary>
        public int? TeacherId { get; set; }
       // public TeacherItemViewModel Teacher { get; set; }
    }
}
