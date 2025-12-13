using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class KitchenInteriorScandinavian : AKitchenInterior
    {
        public KitchenInteriorScandinavian()
        {
            SquareMeters = 8.0;
            FurnitureSet = "Wooden counters";
            ColorScheme = "Natural wood";
            Lighting = "Bright overhead";
            Decoration = "Herbs and pottery";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Scandinavian Kitchen: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}