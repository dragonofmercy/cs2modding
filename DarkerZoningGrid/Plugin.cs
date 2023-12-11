using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace DarkerZoningGrid;

[BepInPlugin("dragon.cs2.darkerzoninggrid", "Darker Zoning Grid", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Info.Metadata.GUID + "_Cities2Harmony");
    }
}