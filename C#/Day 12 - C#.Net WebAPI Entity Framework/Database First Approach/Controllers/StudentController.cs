using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Identity.Client;
using StudentDetailsDBF.Models;
using StudentDetailsDBF.Services.Interfaces;

namespace StudentDetailsDBF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var students=await _student.GetAllStudents();
            if(students == null)
            {
                return NotFound();
            }
            return Ok(students);
           
        }

        [HttpGet("{rollno}")]
        public async Task<ActionResult<Student>> GetStudentById(int rollno)  
        {
                Student student;
                try
                {
                     student = await _student.GetStudentById(rollno);
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
                return Ok(student);


            }
        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudents(Student student)
        {
            var students = await _student.AddStudents(student);
            return Ok(students);    
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(int rollno, Student student)
        {
           
            try
            {
                var students = await _student.UpdateStudent(rollno, student);
                return Ok(students);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
            
            
        }
        [HttpDelete]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno)
        {
            try
            {
                var students = await _student.DeleteStudent(rollno);
                return Ok(students);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        }
}
