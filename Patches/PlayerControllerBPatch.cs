using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;
using BepInEx;
using BepInEx.Logging;

namespace LCOS.RandomSprint.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void randomSprintPatch(ref float ___sprintMultiplier)
        {
            float minMultiplier = 0.5f;
            float maxMultiplier = 5.0f;

            // Randomize the sprint multiplier
            ___sprintMultiplier = Random.Range(minMultiplier, maxMultiplier);
        }
    }
}
