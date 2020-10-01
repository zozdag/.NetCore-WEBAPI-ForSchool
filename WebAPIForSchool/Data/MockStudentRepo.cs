using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIForSchool.Models;

namespace WebAPIForSchool.Data
{
    public class MockStudentRepo : IStudent
    {
        public IEnumerable<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{id=1,Name="Kemal",SurName="Cengiz",StudentNo=12454,StudentClass=2,Age=24,Gender="Male"},
                new Student{id=2,Name="Cem",SurName="Kahya",StudentNo=12345,StudentClass=3,Age=25,Gender="Male"},
                new Student{id=3,Name="Angela",SurName="Hank",StudentNo=12685,StudentClass=4,Age=27,Gender="Female"}
            };
            return students;
        }

        public Student GetStudentById(int id)
        {
            return new Student { id = 1, Name = "Kemal", SurName = "Cengiz", StudentNo = 12454, StudentClass = 2, Age = 24, Gender = "Male" };
        }
    }
}
