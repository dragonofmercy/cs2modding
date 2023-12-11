using Game.Simulation;
using HarmonyLib;

namespace PrecipitationsDisabler.Patches;

[HarmonyPatch(typeof(ClimateSystem), "UpdateSeason")]
internal class ClimateSystemSampleClimatePatch
{
    private static void Postfix(ClimateSystem __instance)
    {
        __instance.temperature.value = 23.0f;
        __instance.precipitation.value = 0.0f;
    }
}