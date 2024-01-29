using System.Reflection;
using BepInEx;
using HarmonyLib;

// ReSharper disable UnusedMember.Local InconsistentNaming RedundantAssignment

namespace LCOnlineFix;

[BepInPlugin("lconlinefix", "LCOnlineFix", "1.0.0")]
public class LCOnlineFix : BaseUnityPlugin
{
    private void Awake() => Harmony.CreateAndPatchAll(typeof(LCOnlineFix).Assembly, "lconlinefix");

    [HarmonyPatch]
    private static class FacepunchTransportPatch
    {
        private const int SPACEWAR_APP_ID = 480;

        [HarmonyTargetMethod]
        private static MethodBase Target() =>
            AccessTools.Method("Netcode.Transports.Facepunch.FacepunchTransport:Awake");

        [HarmonyPrefix]
        private static void Before(ref uint ___steamAppId) =>
            ___steamAppId = SPACEWAR_APP_ID;
    }
}