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
            harmony.PatchAll(typeof(GovernedGasEnginePatches));

            UnityEngine.Debug.Log("RocketThrustOverride: Done!");
        }
    }
}