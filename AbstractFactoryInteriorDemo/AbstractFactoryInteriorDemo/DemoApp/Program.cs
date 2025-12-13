using System;
using InteriorAbstractFactory;

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Factory Pattern Demo ===\n");

            ShowStyle(new RoomInteriorFactoryModern(), "Modern");
            ShowStyle(new RoomInteriorFactoryLoft(), "Loft");
            ShowStyle(new RoomInteriorFactoryScandinavian(), "Scandinavian");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void ShowStyle(ARoomInteriorFactory f, string style)
        {
            Console.WriteLine($"--- {style} Style ---");
            f.CreateLivingRoomInterior().Show();
            f.CreateBedroomInterior().Show();
            f.CreateKitchenInterior().Show();
            Console.WriteLine();
        }
    }
}