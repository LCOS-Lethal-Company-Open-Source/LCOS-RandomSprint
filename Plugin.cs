using System;
using BepInEx;
using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;
namespace Template;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
    private void Awake()
    {
        Logger.LogInfo($"Random sprint active.");
        harmony.PatchAll();
    }
}
