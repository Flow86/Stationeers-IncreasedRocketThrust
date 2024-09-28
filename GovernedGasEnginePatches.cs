using Assets.Scripts.Objects.Pipes;
using HarmonyLib;

namespace RocketThrustOverride.Patches
{
    internal class GovernedGasEnginePatches
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(GovernedGasEngine))]
        [HarmonyPatch("EngineEfficiency", MethodType.Getter)]
        public static bool EngineEfficiency_Prefix(GovernedGasEngine __instance, ref float __result)
        {
            __result = 50f;
            return false;
        }
    }
}
