using CsBasics.data;
using System.Collections.Generic;

namespace CsBasics.repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Students _students;

        public StudentRepository(Students students)
        {
            _students = students;
            _students.PopulateStudents();
        }

        public List<Student> GetAllStudents()
        {
            return _students.GetAllStudents();
        }

        public void AddStudent(Student student)
        {
            _students.AddStudent(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.RemoveStudent(student);
        }

        public Student GetStudent(int index)
        {
            return _students.GetStudent(index);
        }

        public int GetStudentCount()
        {
            return _students.GetStudentCount();
        }

        public void ClearStudents()
        {
            _students.ClearStudents();
        }
    }
    
}