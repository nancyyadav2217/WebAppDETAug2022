using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ODataDemo.Models;
using ODataDemo.Services;

namespace ODataDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService) =>
            this.studentService = studentService;

        [HttpGet]
        
        public ActionResult<IQueryable<Student>> GetAllStudents()
        {
            IQueryable<Student> retrievedStudents =
                this.studentService.RetrieveAllStudents();

            return Ok(retrievedStudents);
        }
    }
}
