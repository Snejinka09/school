using school.Db.Models;

namespace school.web.Data.Services
{
    public class ScheduleService
    {
        List<ScheduleModel> schedules = new List<ScheduleModel>
        {
          new ScheduleModel { Id = 1,Date = new DateTime(2026, 9, 1),LessonNumber = 1,ClassId = 11, },
          new ScheduleModel { Id = 2,Date = new DateTime(2026, 9, 1),LessonNumber = 2,ClassId = 10, },
        };

        public List<ScheduleModel> GetSchedules()
        {
            return schedules;
        }
    }
}
