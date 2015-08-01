using System.Collections;
using UnityEngine;

namespace Assets.World.Rocks
{
    class RockHandler : EntityInterface
    {

        ArrayList rock_names = new ArrayList();
        Rock rock;

        public RockHandler()
        {
            rock = new Rock("rock.medium_1");
        }

        public GameObject load<Rock>(string object_name)
        {
            return rock.load<Rock>(object_name);
        }

        public void updateObject()
        {
            rock.updateObject();
        }
    }
}