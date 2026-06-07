using school.Db.Models;

namespace school.web.PageModels
{
    public class ClassItemViewModel
    {
        private ClassModel _item;
        public ClassModel Item => _item;
        public ClassItemViewModel(ClassModel item)
        {
            item = Item;
        }
        public int Id { get => _item.Id ; set => _item.Id = value; }

        public int Number { get => _item.Number ; set => _item.Number = value; }
    }
}
