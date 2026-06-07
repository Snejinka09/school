using Microsoft.AspNetCore.Components;
using school.web.Data.Services;

namespace school.web.Components.Pages.Cabinet
{
    public class CabinetPageViewModel : ComponentBase
    {
        [Inject] CabinetService CabinetService { get; set; }

		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				var cabinet = CabinetService.GetCabinets();
			}
			return base.OnAfterRenderAsync(firstRender); //класс, который срабатывает при первом рендеринге. 
		}
	}
}
