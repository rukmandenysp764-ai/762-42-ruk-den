using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class LivingRoomInteriorModern : ALivingRoomInterior
    {
        public LivingRoomInteriorModern()
        {
            SquareMeters = 25.0;
            FurnitureSet = "Modern sofa and table";
            ColorScheme = "Neutral tones";
            Lighting = "LED spots";
            Decoration = "Abstract art";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Modern Living Room: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}