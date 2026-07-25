using CsBasics.Services;

namespace CsBasics.UI
{
    public class StudentListUI : IConsoleUI
    {
        private readonly IStudentService _studentService;

        public StudentListUI(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public string Title => "List all students";

        public void Run()
        {
            Console.WriteLine("Menu: 01 All Students");
            foreach (var student in _studentService.GetAllStudents())
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}, Address: {student.Address}");
            }
        }
    }
}
