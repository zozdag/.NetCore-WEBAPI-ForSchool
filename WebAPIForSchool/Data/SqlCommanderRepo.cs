using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebAPIForSchool.Models;

namespace WebAPIForSchool.Data
{
    public class SqlCommanderRepo : IStudent
    {
        private readonly DatabaseContext _context;

        public SqlCommanderRepo(DatabaseContext context)
        {
            _context = context;
        }
        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
    }
}
