using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using HarmonyLib;
using static Obeliskial_Essentials.Essentials;
using System;
using static Ultrafast.CustomFunctions;
using static Ultrafast.Plugin;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Make sure your namespace is the same everywhere
namespace Ultrafast
{

    [HarmonyPatch] //DO NOT REMOVE/CHANGE

    public class Ultrafast
    {
        // To create a patch, you need to declare either a prefix or a postfix. 
        // Prefixes are executed before the original code, postfixes are executed after
        // Then you need to tell Harmony which method to patch.

        [HarmonyPostfix]
        [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.LoadPrefs))]
        public static void LoadPrefsPostfix(ref SettingsManager __instance)
        {
            LogInfo("LoadPrefsPostfix");
            
            return;
        }

        
    }
}