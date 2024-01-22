using BepInEx;
using HarmonyLib;

namespace LCOnlineFix;

[BepInPlugin("lconlinefix", "LCOnlineFix", "1.0.0")]
[BepInProcess("Lethal Company.exe")]
public class LCOnlineFix : BaseUnityPlugin
{
    private void Awake()
    {
        Harmony.CreateAndPatchAll(typeof(LCOnlineFix).Assembly)
    }
}