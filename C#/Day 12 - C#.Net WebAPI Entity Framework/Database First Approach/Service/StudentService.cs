using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetailsDBF.Global_Exceptions;
using StudentDetailsDBF.Models;
using StudentDetailsDBF.Services.Interfaces;

namespace StudentDetailsDBF.Services
{
    public class StudentService : IStudent
    {
        public StudentDbContext? _studentContext;

        public StudentService(StudentDbContext studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<List<Student>> AddStudents(Student student)
        {
            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();
            return await _studentContext.Students.ToListAsync(); 
        }

        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            Student student = await _studentContext.Students.FindAsync(rollno);
            if(student == null)
            {
                throw new Exception(StudentDetailsExceptions.StudentnotFoundException[0]);
            }
            else
            {
                _studentContext.Remove(student);
                await _studentContext.SaveChangesAsync();
                return await _studentContext.Students.ToListAsync();
            }

        }

        public async Task<List<Student>> GetAllStudents()
        {
            var Result = await _studentContext.Students.ToListAsync();
            return Result;
        }

        public async Task<Student> GetStudentById(int rollno)
        {
            var student=await _studentContext.Students.FindAsync(rollno);
            if(student == null)
            {
                throw new Exception(StudentDetailsExceptions.StudentnotFoundException[0]);
            }
            else
            {
                return student;
            }
        }

        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
            Student rstudent = await _studentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.StudentnotFoundException[0]);
            }
            else
            {
                rstudent.Studname= student.Studname;
                rstudent.Addr=student.Addr;
                rstudent.Phno=student.Phno;
                await _studentContext.SaveChangesAsync();

                rstudent = await _studentContext.Students.FindAsync(rollno);

                return rstudent;
            }
        }

       
    }
}
