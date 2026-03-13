using HarmonyLib;
using System;
using UnityEngine;

namespace aimeeBuffmod
{
    #region BepInEx
    [BepInEx.BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class aimeeBuffmod : BepInEx.BaseUnityPlugin
    {
        public const string pluginGuid = "com.username.aimeeBuffmod";
        public const string pluginName = "aimeeBuffmod";
        public const string pluginVersion = "1.0";
        public static void Log(string line)
        {
            Debug.Log("[" + pluginName + "]: " + line);
        }
        void Awake()
        {
            try
            {
                var harmony = new Harmony(pluginGuid);
                harmony.PatchAll();
                Log("Patch succeeded");

            }
            catch (Exception e)
            {

                Log("Patch Failed");
                Log(e.ToString());
            }
        }
    }
    #endregion
}
