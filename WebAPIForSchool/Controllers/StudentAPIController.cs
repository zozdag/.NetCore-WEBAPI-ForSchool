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
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly IStudent _repository;

        public StudentAPIController(IStudent repository)
        {
            _repository = repository;
        }

        //private readonly MockStudentRepo _repo = new MockStudentRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            var StudentItem = _repository.GetStudents();
            return Ok(StudentItem);
        }
       
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudentById(int id)
        {
            var StudentItem = _repository.GetStudentById(id);
            return Ok("your ID : " + id);
        }



    }
}
