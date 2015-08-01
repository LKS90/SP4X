using System.Collections;
using UnityEngine;

namespace Assets.World.Bushes
{
    class GrassBush : EntityInterface
    {
        GameObject bush;

        public GrassBush(string object_name)
        {
            bush = load<GrassBush>(object_name);
        }

        public GameObject load<T>(string object_name)
        {
            return GameObject.Find(object_name);
        }

        public void updateObject()
        {
            Debug.Log(bush.name);
        }
    }
}
