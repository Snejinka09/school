using Microsoft.AspNetCore.Components;
using school.Db.Models;
using school.web.Data.Services;
using school.web.PageModels;

namespace school.web.Pages.Student
{
    
    public class StudentPageViewModel : ComponentBase
    {
        public StudentItemViewModel SelectedStudent { get; set; }
        [Inject]
        public StudentService StudentService { get; set; }
        public List<StudentItemViewModel> Students { get; set; } = new();

        protected override Task OnInitializedAsync()
        {
            Students = StudentService.GetStudents();
            return base.OnInitializedAsync();
        }

        protected void SelectStudent(StudentItemViewModel student)
        {
            SelectedStudent = student;
        }
        protected void Save()
        {
            StudentService.Update(SelectedStudent);
            SelectedStudent = null;
        }
    }
}

