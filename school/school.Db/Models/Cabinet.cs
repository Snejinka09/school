using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{

    [Table("Cabinets")]

    public class Cabinet
    {
        [Key]

        public int Id { get; set; }

        public int Number { get; set; }

        public int? TeacherId { get; set; }
       // public TeacherItemViewModel Teacher { get; set; }
    }
}
