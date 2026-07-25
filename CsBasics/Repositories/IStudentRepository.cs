using CsBasics.data;

namespace CsBasics.repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        Student GetStudent(int index);
        int GetStudentCount();
        void ClearStudents();
    }
}
