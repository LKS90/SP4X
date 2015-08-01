using UnityEngine;

namespace Assets.World
{
    interface EntityInterface
    {
        // <summary>
        // Loads a world object variant of a specific type.</summary>
        //
        // <typeparam name="T">
        // The world object type to load.</typeparam>
        //
        // <param name="object_name">
        // The variation of the world object</param>
        //
        // <return>
        // Returns a GameObject of type T and variant object_name</return>
        GameObject load<T>(string object_name);

        // <summary>
        // Performs the update on the object types.</summary>
        void updateObject();
    }
}
