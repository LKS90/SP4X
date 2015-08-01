using System.Collections;
using UnityEngine;

namespace Assets.World.Trunks
{
    class TrunkHandler : EntityInterface
    {

        ArrayList trunk_names = new ArrayList();
        Trunk trunk;

        public TrunkHandler()
        {
            trunk = new Trunk("stump.hollow_1");
        }

        public GameObject load<Trunk>(string object_name)
        {
            return trunk.load<Trunk>(object_name);
        }

        public void updateObject()
        {
            trunk.updateObject();
        }
    }
}