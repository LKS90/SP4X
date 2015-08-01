using UnityEngine;
using System.Collections;

namespace Assets.World
{
    class WorldBuilder : MonoBehaviour
    {
        GameObject world;
        Flowers.FlowerHandler flowers;
        Bushes.BushHandler bushes;
        Ground.GroundHandler ground;
        Rocks.RockHandler rocks;
        Stumps.StumpHandler stumps;
        Trees.TreeHandler trees;
        Trunks.TrunkHandler trunks;

        // Use this for initialization.
        void Start()
        {
            world = GameObject.Find("World");
            ground = new Ground.GroundHandler();
            flowers = new Flowers.FlowerHandler();
            bushes = new Bushes.BushHandler();
            rocks = new Rocks.RockHandler();
            stumps = new Stumps.StumpHandler();
            trees = new Trees.TreeHandler();
            trunks = new Trunks.TrunkHandler();
        }

        // Update is called once per frame.
        void Update()
        {
            ground.updateObject();
            flowers.updateObject();
            bushes.updateObject();
            rocks.updateObject();
            stumps.updateObject();
            trees.updateObject();
            trunks.updateObject();
        }
    }
}