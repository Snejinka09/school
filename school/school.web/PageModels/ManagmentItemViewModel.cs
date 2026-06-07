using school.Db.Models;


namespace school.Db.Models
{
    public class ManagmentItemViewModel
    {
    private Managment _item;
    public Managment Item => _item;
    public ManagmentItemViewModel(Managment item)
    {
        _item = item;
    }

    public int Id { get => _item.Id; set => _item.Id = value; }

    public string Position { get => _item.Position; set => _item.Position = value; }

    public string FirstName { get => _item.FirstName; set => _item.LastName = value; }

    public string MiddleName { get => _item.MiddleName; set => _item.MiddleName = value; }

    public string LastName { get => _item.LastName; set => _item.LastName = value; }

    public int Age { get => _item.Age; set => _item.Age = value; }
    }
}
