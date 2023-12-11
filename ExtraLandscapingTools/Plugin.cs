using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace ExtraLandscapingTools;

[BepInPlugin("dragon.cs2.extralandscapingtools", "ExtraLandscapingTools", "0.0.1")]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Info.Metadata.GUID + "_Cities2Harmony");
    }
}