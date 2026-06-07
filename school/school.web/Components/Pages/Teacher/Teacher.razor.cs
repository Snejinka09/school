using Microsoft.AspNetCore.Components;
using school.web.Data.Services;

namespace school.web.Components.Pages.Teacher
{
	public class TeacherViewModel : ComponentBase
	{
		[Inject] TeacherService TeacherService { get; set; }
		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				var student = TeacherService.GetTeachers();
			}
			return base.OnAfterRenderAsync(firstRender);
		}
	}
}
