using HarmonyLib;
using KMod;
using UnityEngine;

namespace ONI_TraitMod
{
    public class Mod : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            harmony.PatchAll();
        }
    }
}

        [HarmonyPatch(typeof(SingleSliderSideScreen), "IsValidForTarget")]
        public static class SingleSliderSideScreen_IsValidForTarget_Patch
        {
            public static bool Postfix(GameObject target)
            {
                if(target != null)
                {
                    if(target.GetComponent<WaterBasedGenerator> != null)
                    {
                        return false;
                    }               
                }
            }
        }
