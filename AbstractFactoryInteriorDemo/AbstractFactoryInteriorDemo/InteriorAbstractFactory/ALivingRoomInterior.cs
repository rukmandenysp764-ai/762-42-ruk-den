using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public abstract class ALivingRoomInterior
    {
        public double SquareMeters { get; set; }
        public string FurnitureSet { get; set; } = string.Empty!;
        public string ColorScheme { get; set; } = string.Empty!;
        public string Lighting { get; set; } = string.Empty!;
        public string Decoration { get; set; } = string.Empty!;

        public abstract void Show();
        public abstract string GetInfo();
    }
}
