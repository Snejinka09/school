using school.Db.Models;

public class StudentItemViewModel
{
    private StudentModel _item;
    public StudentModel Item => _item;

    public StudentItemViewModel(StudentModel item)
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

    public int ClassId
    {
        get => _item.ClassId;
        set => _item.ClassId = value;
    }

    public virtual ClassModel Class { get; set; }
}
