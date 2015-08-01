using System.Collections;
using UnityEngine;

namespace Assets.World.Trees
{
    class TreeHandler : EntityInterface
    {

        ArrayList tree_names = new ArrayList();
        Tree tree;

        public TreeHandler()
        {
            tree = new Tree("stump.hollow_1");
        }

        public GameObject load<Tree>(string object_name)
        {
            return tree.load<Tree>(object_name);
        }

        public void updateObject()
        {
            tree.updateObject();
        }
    }
}