
using CsBasics.data;
using CsBasics.repositories;
using CsBasics.Services;
using CsBasics.UI;
using CsBasics.UI.CSharp10;
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
            services.AddTransient<IConsoleUI, CSharp10UI>();
            services.AddTransient<ConsoleMenu>();

            // CSharp10UI demo registrations — add new ICSharp10Demo implementations here
            services.AddTransient<ICSharp10Demo, GarbageCollectionDemo>();
            services.AddTransient<ICSharp10Demo, DelegatesDemo>();
            services.AddTransient<ICSharp10Demo, EventsDemo>();

            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetRequiredService<ConsoleMenu>().Launch();
        }
    }
}