using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public abstract class ARoomInteriorFactory
    {
        public abstract ALivingRoomInterior CreateLivingRoomInterior();
        public abstract ABedroomInterior CreateBedroomInterior();
        public abstract AKitchenInterior CreateKitchenInterior();
    }
}