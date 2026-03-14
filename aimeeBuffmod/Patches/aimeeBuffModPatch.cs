using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Assets.Scripts.Objects;

namespace aimeeBuffmod.Patches
{
  [HarmonyPatch]internal class aimeeBuffModPatch
  {
    [HarmonyPatch(typeof(RobotMining), "Awake")]
    [HarmonyPostfix]
    static void RobotMiningAwakePostfix(RobotMining __instance)
    {
      __instance.MaxSpeed = 2.6f; // Increase max speed
      __instance.WeatherDamageScale = 0.25f; // Reduce weather damage
    }
  }
}
