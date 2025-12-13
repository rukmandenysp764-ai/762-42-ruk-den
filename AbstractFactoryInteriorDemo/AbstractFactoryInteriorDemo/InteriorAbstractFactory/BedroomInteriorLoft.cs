using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class BedroomInteriorLoft : ABedroomInterior
    {
        public BedroomInteriorLoft()
        {
            SquareMeters = 18.0;
            FurnitureSet = "Metal frame bed";
            ColorScheme = "Exposed brick";
            Lighting = "Industrial lamps";
            Decoration = "Urban art";
        }

        public override void Show()
        {
            Console.WriteLine($"Showing Loft Bedroom: {GetInfo()}");
        }

        public override string GetInfo()
        {
            return $"SquareMeters: {SquareMeters}, Furniture: {FurnitureSet}, Color: {ColorScheme}, Lighting: {Lighting}, Decoration: {Decoration}";
        }
    }
}