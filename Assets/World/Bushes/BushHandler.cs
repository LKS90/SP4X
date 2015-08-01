using System.Collections;
using UnityEngine;

namespace Assets.World.Bushes
{
    class BushHandler : EntityInterface
    {

        ArrayList bushes_names = new ArrayList();
        GrassBush bush;

        public BushHandler()
        {
            bush = new GrassBush("bush.grass");
        }

        public void updateObject()
        {
            this.bush.updateObject();
        }

        public GameObject load<GrassBush>(string object_name)
        {
            return bush.load<GrassBush>(object_name);
        }
    }
}