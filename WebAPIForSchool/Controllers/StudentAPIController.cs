using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIForSchool.Data;
using WebAPIForSchool.Models;

namespace WebAPIForSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {

        private readonly MockStudentRepo _repo = new MockStudentRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            var StudentItem = _repo.GetStudents();
            return Ok(StudentItem);
        }


       
    }
}
