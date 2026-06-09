using school.Db.Models;

namespace school.web.PageModels
{
    public class TeacherItemViewModel
    {
        private TeacherModel _item;
        public TeacherModel Item => _item;

        public TeacherItemViewModel(TeacherModel item)
        {
            _item = item;
        }

        public int Id
        {
            get => _item.Id;
            set => _item.Id = value;
        }

        public string FirstName
        {
            get => _item.FirstName;
            set => _item.FirstName = value;
        }

        public string MiddleName
        {
            get => _item.MiddleName;
            set => _item.MiddleName = value;
        }

        public string LastName
        {
            get => _item.LastName;
            set => _item.LastName = value;
        }

        public int Age
        {
            get => _item.Age;
            set => _item.Age = value;
        }

        public string SubjectName
        {
            get => _item.SubjectName;
            set => _item.SubjectName = value;
        }
    }
}