using Game.Simulation;
using HarmonyLib;
using JetBrains.Annotations;

namespace PrecipitationsDisabler.Patches;

[HarmonyPatch(typeof(ClimateSystem), "UpdateSeason")]
internal class ClimateSystemSampleClimatePatch
{
    [UsedImplicitly]
    private static void Postfix(ClimateSystem __instance)
    {
        __instance.temperature.value = 23.0f;
        __instance.precipitation.value = 0.0f;
    }
}