using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{
    public class ScheduleItemViewModel
    {
        private ScheduleModel _item;
        public ScheduleModel Item => _item;
        public ScheduleItemViewModel(ScheduleModel item)
        {
            _item = item;
        }

        public int Id { get => _item.Id; set => _item.Id = value; }

        public DateTime Date { get => _item.Date; set => _item.Date = value; }

        public int LessonNumber { get => _item.LessonNumber; set => _item.LessonNumber = value; }

        public int? TeacherId { get => _item.TeacherId; set => _item.TeacherId = value; }

        public int? CabinetId { get => _item.CabinetId; set => _item.CabinetId = value; }

        public int ClassId { get => _item.ClassId; set => _item.ClassId = value; }


        public virtual CabinetItemViewModel Cabinet { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ClassModel Class { get; set; }
    }
}
