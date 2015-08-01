using UnityEngine;
using System.Collections;

namespace Assets.World.Ground
{
    class BasicTile
    {

        public GameObject tile;

        public BasicTile()
        {
            tile = GameObject.Find("ground.basic");
        }

        public void updateObject()
        {
            Debug.Log(tile.name);
        }
    }
}

