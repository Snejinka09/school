using Microsoft.AspNetCore.Components;
using school.Db.Models;
using school.web.Data.Services;
using school.web.PageModels;
using school.web.PageModels.Students;

namespace school.web.Pages.Student
{
    
    public class StudentPageViewModel : ComponentBase
    {
        protected EditSudentModel EditModel { get; set; } = new();
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
            EditModel = new();
            EditModel.Model = (StudentItemViewModel)student.Clone();
            EditModel.IsOpenDialog = true;
            StateHasChanged();
        }
        protected void Save()
        {
            StudentService.Update(SelectedStudent);
            SelectedStudent = null;
        }
        protected void SaveChanges(StudentItemViewModel item)
        {
            if (item != null)
            {
                if (item.Id == 0)
                {
                    StudentService.AddStudent(item);
                }

                else
                {
                    StudentService.Update(item);
                }

                Students = StudentService.GetStudents();
                item = null;
                StateHasChanged();
            }
            else
            {
                EditModel.IsOpenDialog = false;
                StateHasChanged();
            }            
        }

        public void AddNewStudent()
        {
            EditModel = new();
            EditModel.Model = new StudentItemViewModel(new StudentModel());
            EditModel.IsOpenDialog = true;
            StateHasChanged();
        }
    }
}

