using Microsoft.AspNetCore.Components;
using school.web.Data.Services;

namespace school.web.Components.Pages.ClassModel
{
	public class ClassModelPageViewModel : ComponentBase 
	{
		[Inject] ClassModelService ClassModelService { get; set; }

		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				var classmodel = ClassModelService.GetClassModels();
			}
			return base.OnAfterRenderAsync(firstRender);
		}
	}
}
