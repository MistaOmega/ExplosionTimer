using BepInEx;
using HarmonyLib;

namespace ExplosionTimer
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Harmony harmony = Harmony.CreateAndPatchAll(typeof(ExplosionPatch));
            Logger.LogInfo($"Harmony has patched all methods for ExplosionPatch");
        }
    }
}
