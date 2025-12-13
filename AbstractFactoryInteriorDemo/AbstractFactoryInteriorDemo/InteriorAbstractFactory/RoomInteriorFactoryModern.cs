using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class RoomInteriorFactoryModern : ARoomInteriorFactory
    {
        public override ALivingRoomInterior CreateLivingRoomInterior()
        {
            return new LivingRoomInteriorModern();
        }

        public override ABedroomInterior CreateBedroomInterior()
        {
            return new BedroomInteriorModern();
        }

        public override AKitchenInterior CreateKitchenInterior()
        {
            return new KitchenInteriorModern();
        }
    }
}