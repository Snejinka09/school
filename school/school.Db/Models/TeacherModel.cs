using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{
    [Table("Teachers")]

    public class TeacherModel : ICloneable
    {
        [Key]

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string SubjectName { get; set; }

        public object Clone()
        {
            TeacherModel tempObject = (TeacherModel)MemberwiseClone();
            return tempObject;
        }
    }
    
}
