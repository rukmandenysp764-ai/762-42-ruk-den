using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class BedroomInteriorModern : ABedroomInterior
    {
        public BedroomInteriorModern()
        {
            SquareMeters = 15.0;
            FurnitureSet = "Platform bed";
            ColorScheme = "Gray and black";
            Lighting = "Ambient LED";
            Decoration = "Minimalist";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Modern Bedroom: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}