using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{
    [Table("Students")] //параметры передаем таблицу "Students"

    public class StudentModel
    {
        [Key]

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int ClassId { get; set; }
	}
}
