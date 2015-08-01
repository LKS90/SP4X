using UnityEngine;
using System.Collections;

namespace Assets.World.Trees
{
    class Tree : EntityInterface
    {
        GameObject tree;

        public Tree(string object_name)
        {
            tree = load<Tree>(object_name);
        }

        public GameObject load<Tree>(string object_name)
        {
            return GameObject.Find(object_name);
        }

        public void updateObject()
        {
            Debug.Log(tree.name);
        }
    }
}