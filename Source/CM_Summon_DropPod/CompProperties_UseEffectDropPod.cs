using RimWorld;
using Verse;
namespace CM_Summon_DropPod
{
    public class CompProperties_UseEffectDropPod : CompProperties_Usable
    {
        public ThingDef thingDef;
        public int amount = 0;

        public CompProperties_UseEffectDropPod()
        {
            compClass = typeof(CompProperties_UseEffectDropPod);
        }
    }
}
