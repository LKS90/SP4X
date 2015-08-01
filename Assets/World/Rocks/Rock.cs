using UnityEngine;
using System.Collections;

namespace Assets.World.Rocks
{
    class Rock : EntityInterface
    {
        GameObject rock;

        public Rock(string object_name)
        {
            rock = load<Rock>(object_name);
        }

        public GameObject load<Rock>(string object_name)
        {
            return GameObject.Find(object_name);
        }

        public void updateObject()
        {
            Debug.Log(rock.name);
        }
    }
}
