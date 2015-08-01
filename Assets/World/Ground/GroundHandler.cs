using System.Collections;

namespace Assets.World.Ground
{
    class GroundHandler
    {

        BasicTile tile;

        public GroundHandler()
        {
            tile = new BasicTile();
        }

        public void updateObject()
        {
            tile.updateObject();
        }
    }
}