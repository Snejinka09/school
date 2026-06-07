using Microsoft.AspNetCore.Components;
using school.Db.Models;
using school.web.Data.Services;

namespace school.web.Components.Pages.Student
{
		public class StudentPageViewModel : ComponentBase
        {
        [Inject] StudentService StudentService { get; set; }
		protected List<school.Db.Models.Student> Students { get; set; } = new();

        protected override Task OnInitializedAsync()
        {
            Students = StudentService.GetStudents();
            return base.OnInitializedAsync();
        }
        }
}

