using Microsoft.AspNetCore.Components;
using school.web.Data.Services;

namespace school.web.Components.Pages.Managment
{
	public class ManagmentPageViewModel : ComponentBase
	{
		[Inject] ManagmentService ManagmentService { get; set; }

		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				var classmodel = ManagmentService.GetManagments();
			}
			return base.OnAfterRenderAsync(firstRender);
		}
	}
}
