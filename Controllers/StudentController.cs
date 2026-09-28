using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using branchesPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace branchesPractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService; 

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService; 
        }

        [HttpGet("GetAll")]
        public ActionResult<List<string>> getAll()
        {
            return Ok(_studentService.StudentGetAll()); 
        }
    }
}