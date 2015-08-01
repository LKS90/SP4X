using System.Collections;
using UnityEngine;

namespace Assets.World.Flowers
{
    class FlowerHandler : EntityInterface
    {

        ArrayList flowers = new ArrayList();
        Flower flower;

        public FlowerHandler()
        {
            flower = new Flower("flower.red_1");
        }

        public GameObject load<Flower>(string object_name)
        {
            return flower.load<Flower>(object_name);
        }

        public void updateObject()
        {
            flower.updateObject();
        }
    }
}