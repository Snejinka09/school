using Microsoft.AspNetCore.Components;
using school.Db.Models;
using school.web.Data.Services;
using school.web.PageModels.Managments;

namespace school.web.Components.Pages.Managment
{
	public class ManagmentPageViewModel : ComponentBase
	{
		[Inject] ManagmentService ManagmentService { get; set; }
        protected EditManagmentModel EditModel { get; set; } = new();
        public ManagmentItemViewModel SelectedManagment { get; set; }
        public List<ManagmentItemViewModel> Managment { get; set; } = new();

        protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				var classmodel = ManagmentService.GetManagments();
			}
			return base.OnAfterRenderAsync(firstRender);
		}
        protected void SelectManagment(ManagmentItemViewModel managment)
        {
            SelectedManagment = managment;
            EditModel = new();
            EditModel.Model = (ManagmentItemViewModel)managment.Clone();
            EditModel.IsOpenDialog = true;
            StateHasChanged();
        }
        protected void Save()
        {
            ManagmentService.Update(SelectedManagment);
            SelectedManagment = null;
        }
        protected void SaveChanges(ManagmentItemViewModel item)
        {
            if (item != null)
            {
                if (item.Id == 0)
                {
                    ManagmentService.AddManagment(item);
                }

                else
                {
                    ManagmentService.Update(item);
                }

                Managment = ManagmentService.GetManagments();
                item = null;
                StateHasChanged();
            }
            else
            {
                EditModel.IsOpenDialog = false;
                StateHasChanged();
            }
        }

        public void AddNewManagment()
        {
            EditModel = new();
            EditModel.Model = new ManagmentItemViewModel(new school.Db.Models.Managment());
            EditModel.IsOpenDialog = true;
            StateHasChanged();
        }
    }
}
