using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw4.DAL;
using cw4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw4.Controllers
{

    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        public string GetStudents()
        {
            return "Kowalski, Nowak";
        }
        [HttpGet("{id}")]
        public IActionResult GetStudenst(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Nowak");
            }

            return NotFound("Nie ma studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 2000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            return Ok("Aktualizacja zakonczona");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok("Student o id: " + id + " zostal usuniety");
        }

        private readonly IDbService _dbService;
        public StudentsController(IDbService db)
        {
            _dbService = db;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

    }
}