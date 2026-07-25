namespace CsBasics.UI
{
    public class ConsoleMenu
    {
        private readonly IEnumerable<IConsoleUI> _uis;

        public ConsoleMenu(IEnumerable<IConsoleUI> uis)
        {
            _uis = uis;
        }

        public void Launch()
        {
            var uiList = _uis.ToList();

            while (true)
            {
                Console.WriteLine("\nMain Menu");
                for (int i = 0; i < uiList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {uiList[i].Title}");
                }
                Console.WriteLine("0. Exit");
                Console.Write("\nSelect an option: ");

                var input = Console.ReadLine();
                if (!int.TryParse(input, out int choice)) continue;

                if (choice == 0) break;
                if (choice >= 1 && choice <= uiList.Count)
                {
                    Console.WriteLine();
                    uiList[choice - 1].Run();
                }
            }
        }
    }
}
