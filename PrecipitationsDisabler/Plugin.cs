﻿using BepInEx;
using HarmonyLib;
using System.Reflection;
using JetBrains.Annotations;

namespace PrecipitationsDisabler;

[BepInPlugin("dragon.cs2.precipitationsdisabler", "PrecipitationsDisabler", "0.0.1")]
public class Plugin : BaseUnityPlugin
{
    [UsedImplicitly]
    private void Awake()
    {
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Info.Metadata.GUID + "_Cities2Harmony");
    }
}