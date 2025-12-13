using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class RoomInteriorFactoryScandinavian : ARoomInteriorFactory
    {
        public override ALivingRoomInterior CreateLivingRoomInterior()
        {
            return new LivingRoomInteriorScandinavian();
        }

        public override ABedroomInterior CreateBedroomInterior()
        {
            return new BedroomInteriorScandinavian();
        }

        public override AKitchenInterior CreateKitchenInterior()
        {
            return new KitchenInteriorScandinavian();
        }
    }
}