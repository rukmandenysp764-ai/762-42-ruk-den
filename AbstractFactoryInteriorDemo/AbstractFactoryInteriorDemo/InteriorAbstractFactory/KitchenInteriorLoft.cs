using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class KitchenInteriorLoft : AKitchenInterior
    {
        public KitchenInteriorLoft()
        {
            SquareMeters = 12.0;
            FurnitureSet = "Open shelves";
            ColorScheme = "Dark metals";
            Lighting = "Pendant lights";
            Decoration = "Exposed pipes";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Loft Kitchen: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}