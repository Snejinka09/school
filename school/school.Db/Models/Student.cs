using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Db.Models
{

    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int ClassId { get; set; }


		public Student(int id, string firstName, string middleName, string lastName, int age, int classId)
		{
        Id = id;
        FirstName = firstName;
		MiddleName = middleName;
		LastName = lastName;
		Age = age;
		ClassId = classId;
		}
	}
 
}
