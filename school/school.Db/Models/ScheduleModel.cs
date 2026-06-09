using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{
    [Table("Schedules")]

    public class ScheduleModel
    {
        [Key]

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int LessonNumber { get; set; }

        public int? TeacherId { get; set; }

        public int? CabinetId { get; set; }

        public int ClassId { get; set; }
    }
}
