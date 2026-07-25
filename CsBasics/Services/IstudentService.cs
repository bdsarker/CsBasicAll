using CsBasics.data;

namespace CsBasics.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        Student GetStudent(int index);
        int GetStudentCount();
        void ClearStudents();
    }
}