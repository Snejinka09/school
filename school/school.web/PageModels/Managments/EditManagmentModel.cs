using Microsoft.EntityFrameworkCore;
using school.web.PageModels.Teachers;

namespace school.web.PageModels.Managments
{
    public class EditManagmentModel
    {
        public bool IsOpenDialog { get; set; }
        public ManagmentItemViewModel Model { get; set; }
    }
}

