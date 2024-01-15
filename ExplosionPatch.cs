using HarmonyLib;

namespace ExplosionTimer;


public class ExplosionPatch
{
    [HarmonyPatch(typeof(CrashedShipExploder), nameof(CrashedShipExploder.SetExplodeTime))]
    [HarmonyPrefix]
    static bool Prefix(CrashedShipExploder __instance)
    {
        float num = UnityEngine.Random.Range(2.3f, 2.35f);
        __instance.timeToStartWarning = DayNightCycle.main.timePassedAsFloat;
        __instance.timeToStartCountdown = __instance.timeToStartWarning + num * 1200f;
        return false;
    }
}