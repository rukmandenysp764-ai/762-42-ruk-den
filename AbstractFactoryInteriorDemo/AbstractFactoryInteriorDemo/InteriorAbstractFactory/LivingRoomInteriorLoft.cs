using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class LivingRoomInteriorLoft : ALivingRoomInterior
    {
        public LivingRoomInteriorLoft()
        {
            SquareMeters = 30.0;
            FurnitureSet = "Industrial furniture";
            ColorScheme = "Brick red";
            Lighting = "Exposed bulbs";
            Decoration = "Vintage posters";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Loft Living Room: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}