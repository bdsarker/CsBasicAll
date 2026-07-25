using CsBasics.data;
using CsBasics.repositories;
using System.Collections.Generic;

namespace CsBasics.Services
{
    // Call the repository to manage students
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public void RemoveStudent(Student student)
        {
            _studentRepository.RemoveStudent(student);
        }

        public Student GetStudent(int index)
        {
            return _studentRepository.GetStudent(index);
        }

        public int GetStudentCount()
        {
            return _studentRepository.GetStudentCount();
        }

        public void ClearStudents()
        {
            _studentRepository.ClearStudents();
        }
    }
}