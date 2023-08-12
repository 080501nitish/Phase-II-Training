using StudentDetailsDBF.Models;

namespace StudentDetailsDBF.Services.Interfaces
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentById(int rollno);

        Task<List<Student>> AddStudents(Student student);

        Task<Student> UpdateStudent(int id,Student student);
        Task<List<Student>> DeleteStudent(int rollno);


    }
}
