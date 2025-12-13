using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class LivingRoomInteriorScandinavian : ALivingRoomInterior
    {
        public LivingRoomInteriorScandinavian()
        {
            SquareMeters = 20.0;
            FurnitureSet = "Minimalist wood";
            ColorScheme = "White and pastels";
            Lighting = "Natural light lamps";
            Decoration = "Plants and textiles";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Scandinavian Living Room: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}