using FactoryMethodClass; // Это станет работать после добавления ссылки

namespace FactoryMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Master[] masters = new Master[]
            {
                new ClassicMaster(),
                new BaroqueMaster(),
                new ModernMaster()
            };

            foreach (var master in masters)
            {
                Facade facade = master.CreateFacade();
                facade.Display();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}