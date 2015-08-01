using UnityEngine;
using System.Collections;

namespace Assets.World.Trunks
{
    class Trunk : EntityInterface
    {
        GameObject trunk;

        public Trunk(string object_name)
        {
            trunk = load<Trunk>(object_name);
        }

        public GameObject load<Trunk>(string object_name)
        {
            return GameObject.Find(object_name);
        }

        public void updateObject()
        {
            Debug.Log(trunk.name);
        }
    }
}