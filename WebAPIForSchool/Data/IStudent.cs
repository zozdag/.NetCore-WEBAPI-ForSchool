using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIForSchool.Models;

namespace WebAPIForSchool.Data
{
    public interface IStudent
    {
        public IEnumerable<Student> GetStudents();
        public Student GetStudentById(int id);


    }
}
