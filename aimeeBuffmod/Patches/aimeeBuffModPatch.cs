using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Assets.Scripts.Objects;

namespace aimeeBuffmod.Patches
{
  internal class aimeeBuffModPatch
  {
    [HarmonyPatch(typeof(RobotMining), "Awake")]
    [HarmonyPostfix]
    static void RobotMiningAwakePostfix(RobotMining __instance)
    {
      __instance.MaxSpeed = 6f; // Double the speed from 3f to 6f
      __instance.WeatherDamageScale = 0.5f; // Halve the storm damage from 1f to 0.5f
    }
  }
}
