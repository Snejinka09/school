using Microsoft.AspNetCore.Components;
using school.web.Data.Services;
using school.web.PageModels;

namespace school.web.Components.Pages.Teacher
{
	public class TeacherPageViewModel : ComponentBase
	{
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
		}
		protected void Save()
		{
			TeacherService.Update(SelectedTeacher);
			SelectedTeacher = null;
		}
			
	}
}
