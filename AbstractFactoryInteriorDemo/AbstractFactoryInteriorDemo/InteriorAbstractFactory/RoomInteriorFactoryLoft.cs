using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorAbstractFactory
{
    public class RoomInteriorFactoryLoft : ARoomInteriorFactory
    {
        public override ALivingRoomInterior CreateLivingRoomInterior()
        {
            return new LivingRoomInteriorLoft();
        }

        public override ABedroomInterior CreateBedroomInterior()
        {
            return new BedroomInteriorLoft();
        }

        public override AKitchenInterior CreateKitchenInterior()
        {
            return new KitchenInteriorLoft();
        }
    }
}