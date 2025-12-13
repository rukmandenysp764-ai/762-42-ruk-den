using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class BedroomInteriorScandinavian : ABedroomInterior
    {
        public BedroomInteriorScandinavian()
        {
            SquareMeters = 12.0;
            FurnitureSet = "Wooden bed";
            ColorScheme = "Light blue";
            Lighting = "Soft daylight";
            Decoration = "Cozy blankets";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Scandinavian Bedroom: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}