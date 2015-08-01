using System.Collections;
using UnityEngine;

namespace Assets.World.Stumps
{
    class StumpHandler : EntityInterface
    {

        ArrayList stump_names = new ArrayList();
        Stump stump;

        public StumpHandler()
        {
            stump = new Stump("stump.hollow_1");
        }

        public GameObject load<Stump>(string object_name)
        {
            return stump.load<Stump>(object_name);
        }

        public void updateObject()
        {
            stump.updateObject();
        }
    }
}