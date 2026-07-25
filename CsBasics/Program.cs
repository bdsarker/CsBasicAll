
using CsBasics.data;
using CsBasics.repositories;
using CsBasics.Services;
using CsBasics.UI;
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

            // UI registrations — add new IConsoleUI implementations here
            services.AddTransient<IConsoleUI, StudentListUI>();
            services.AddTransient<ConsoleMenu>();

            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetRequiredService<ConsoleMenu>().Launch();
        }
    }
}