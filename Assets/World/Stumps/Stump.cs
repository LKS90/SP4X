using UnityEngine;
using System.Collections;

namespace Assets.World.Stumps
{
    class Stump : EntityInterface
    {
        GameObject stump;

        public Stump(string object_name)
        {
            stump = load<Stump>(object_name);
        }

        public GameObject load<Stump>(string object_name)
        {
            return GameObject.Find(object_name);
        }

        public void updateObject()
        {
            Debug.Log(stump.name);
        }
    }
}