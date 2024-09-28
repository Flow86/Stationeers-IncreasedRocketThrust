using HarmonyLib;
using StationeersMods.Interface;

using RocketThrustOverride.Patches;

namespace RocketThrustOverride
{
    class RocketThrustOverride : ModBehaviour
    {
        public override void OnLoaded(ContentHandler contentHandler)
        {
            UnityEngine.Debug.Log("RocketThrustOverride: Hello!");

            Harmony harmony = new Harmony("RocketThrustOverridePatches");
            harmony.PatchAll(typeof(InventoryWindowPatches));

            UnityEngine.Debug.Log("RocketThrustOverride: Done!");
        }
    }
}