using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class KitchenInteriorModern : AKitchenInterior
    {
        public KitchenInteriorModern()
        {
            SquareMeters = 10.0;
            FurnitureSet = "Sleek cabinets";
            ColorScheme = "White gloss";
            Lighting = "Under-cabinet LEDs";
            Decoration = "Modern appliances";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Modern Kitchen: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}