using System.Collections.Generic;
using System.Linq;

using Game.Prefabs;
using Game.SceneFlow;

using HarmonyLib;
using Unity.Entities;

namespace ExtraLandscapingTools.Patches;

[HarmonyPatch(typeof(GameManager), "InitializeThumbnails")]
internal class GameManagerInitializeThumbnailsPatch
{
    static void Prefix(GameManager __instance)
    {
        World world = Traverse.Create(__instance).Field<World>("m_World").Value;
        PrefabSystem prefabSystem = world.GetExistingSystemManaged<PrefabSystem>();
        List<PrefabBase> prefabs = Traverse.Create(prefabSystem).Field<List<PrefabBase>>("m_Prefabs").Value;

        string[] tools = {
            "Ore Resource Tool",
            "Oil Resource Tool",
            "FertileLand Resource Tool",
            "GroundWater Resource Tool"
        };

        PrefabBase basePrefab = prefabs.FirstOrDefault(p => p.name == "Terrain Shift Tool");
        UIObject basePrefabUiObject = basePrefab.GetComponent<UIObject>();

        foreach(string tool in tools)
        {
            PrefabBase prefab = prefabs.FirstOrDefault(p => p.name == tool);
            UIObject prefabUiObject = prefab.GetComponent<UIObject>();
            prefabUiObject.m_Group = basePrefabUiObject.m_Group;
        }
    }
}