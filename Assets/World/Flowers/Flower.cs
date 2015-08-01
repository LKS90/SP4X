using System.Collections;
using UnityEngine;

namespace Assets.World.Flowers
{
    class Flower : EntityInterface
    {
        GameObject flower;

        public Flower(string object_name)
        {
            flower = load<Flower>(object_name);
        }

        public GameObject load<Flower>(string object_name)
        {
            return GameObject.Find(object_name);
        }

        public void updateObject()
        {
            Debug.Log(flower.name);
        }
    }
}
