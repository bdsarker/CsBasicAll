namespace CsBasics.data
{
    using System.Collections.Generic;
    public class Students
    {
        public List<Student> StudentList { get; set; }

        public Students()
        {
            StudentList = new List<Student>();
        }
        public void PopulateStudents()
        {
            StudentList = new List<Student>
            {
                new Student { Name = "John Doe", Age = 18, Grade = "A", Address = "123 Main St" },
                new Student { Name = "Jane Smith", Age = 19, Grade = "B", Address = "456 Elm St" },
                new Student { Name = "Alice Johnson", Age = 17, Grade = "A", Address = "789 Oak St" }
            };
        }
        public List<Student> GetAllStudents()
        {
            return StudentList;
        }
        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            StudentList.Remove(student);
        }
        public Student GetStudent(int index)
        {
            if (index >= 0 && index < StudentList.Count)
            {
                return StudentList[index];
            }
            return null;
        }
        public int GetStudentCount()
        {
            return StudentList.Count;
        }
        public void ClearStudents()
        {
            StudentList.Clear();
        }
    }
}