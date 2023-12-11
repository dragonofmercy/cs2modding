using Game.Prefabs;
using HarmonyLib;

namespace DarkerZoningGrid.Patches;

[HarmonyPatch(typeof(PrefabBase), "OnEnable")]
internal class PrefabBaseOnEnablePatch
{
    private static void Postfix(PrefabBase __instance)
    {
        if(__instance is not ZonePrefab zonePrefab || zonePrefab.m_AreaType != Game.Zones.AreaType.None) return;

        zonePrefab.m_Color = new UnityEngine.Color(1f, 1f, 1f, 0f);
        zonePrefab.m_Edge =  new UnityEngine.Color(1f, 1f, 1f, 0.1f);
    }
}