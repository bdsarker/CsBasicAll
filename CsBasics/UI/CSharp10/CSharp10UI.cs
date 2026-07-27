using CsBasics.UI;

namespace CsBasics.UI.CSharp10
{
    public class CSharp10UI : IConsoleUI
    {
        private readonly IEnumerable<ICSharp10Demo> _demos;

        public CSharp10UI(IEnumerable<ICSharp10Demo> demos)
        {
            _demos = demos;
        }

        public string Title => "C# 1.0 Features";

        public void Run()
        {
            var demoList = _demos.ToList();

            while (true)
            {
                Console.WriteLine("\nC# 1.0 Features Menu");
                for (int i = 0; i < demoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {demoList[i].Title}");
                }
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("\nSelect an option: ");

                var input = Console.ReadLine();
                if (!int.TryParse(input, out int choice)) continue;

                if (choice == 0) break;
                if (choice >= 1 && choice <= demoList.Count)
                {
                    Console.WriteLine();
                    demoList[choice - 1].Run();
                }
            }
        }
    }
}
