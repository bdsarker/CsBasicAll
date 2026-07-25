
using CsBasics.data;
using CsBasics.repositories;
using CsBasics.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CsBasics
{
    class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<Students>();
            services.AddSingleton<IStudentRepository, StudentRepository>();
            services.AddTransient<IStudentService, StudentService>();

            var serviceProvider = services.BuildServiceProvider();

            var studentService = serviceProvider.GetRequiredService<IStudentService>();

            Console.WriteLine("The list of students:");
            foreach (var student in studentService.GetAllStudents())
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}, Address: {student.Address}");
            }
            
        }
    }
}