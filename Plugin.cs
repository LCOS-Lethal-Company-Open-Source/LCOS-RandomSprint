using System;
using BepInEx;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;
using LCOS.RandomSprint.Patches;
using UnityEngine;
namespace LCOS.RandomSprint;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);

    private static Plugin Instance;

    internal ManualLogSource mls;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        mls = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.PLUGIN_GUID);

        mls.LogInfo($"Random sprint active.");

        harmony.PatchAll(typeof(Plugin));
        harmony.PatchAll(typeof(PlayerControllerBPatch));
    }
}
