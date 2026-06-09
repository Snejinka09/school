using Microsoft.AspNetCore.Components;
using school.Db.Models;
using school.web.Data.Services;

namespace school.web.Components.Pages.Schedule
{
	public class ScheduleViewModel : ComponentBase
	{
		[Inject] ScheduleService ScheduleService { get; set; }
        public List<ScheduleItemViewModel> Schedule { get; set; } = new();

        protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
                Schedule = ScheduleService.GetSchedules();
				StateHasChanged();
			}
			return base.OnAfterRenderAsync(firstRender);
		}
	}
}
