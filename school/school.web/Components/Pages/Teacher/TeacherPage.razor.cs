using Microsoft.AspNetCore.Components;
using school.Db.Models;
using school.web.Data.Services;
using school.web.PageModels.Teachers;

namespace school.web.Components.Pages.Teacher
{
	public class TeacherPageViewModel : ComponentBase
	{
		protected EditTeacherModel EditModel { get; set; } = new();
        public TeacherItemViewModel SelectedTeacher { get; set; }
		[Inject] 
		public TeacherService TeacherService { get; set; }
		public List<TeacherItemViewModel> Teachers { get; set; } = new();

		protected override Task OnInitializedAsync()
		{		
			Teachers = TeacherService.GetTeachers();
			return base.OnInitializedAsync();
		}
		protected void SelectTeacher(TeacherItemViewModel teacher)
		{
			SelectedTeacher = teacher;
            EditModel = new();
            EditModel.Model = (TeacherItemViewModel)teacher.Clone();
            EditModel.IsOpenDialog = true;
            StateHasChanged();
        }
		protected void Save()
		{
			TeacherService.Update(SelectedTeacher);
			SelectedTeacher = null;
		}

		public void SaveChanges(TeacherItemViewModel item)
        {
            if (item != null)
            {
                if (item.Id == 0)
                {
                    TeacherService.AddTeacher(item);
                }

                else
                {
                    TeacherService.Update(item);
                }

                Teachers = TeacherService.GetTeachers();
                item = null;
                StateHasChanged();
            }
            else
            {
                EditModel.IsOpenDialog = false;
                StateHasChanged();
            }
        }

        public void AddNewTeacher()
		{
            EditModel = new();
            EditModel.Model = new TeacherItemViewModel(new TeacherModel());
            EditModel.IsOpenDialog = true;
            StateHasChanged();
        }
        public void DeleteTeacher(TeacherItemViewModel teacher)
        {
            TeacherService.RemoveTeacher(teacher);
            Teachers = TeacherService.GetTeachers();
            StateHasChanged();
        }


    }
}
