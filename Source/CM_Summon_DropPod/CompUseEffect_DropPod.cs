using RimWorld;
using Verse;

namespace CM_Summon_DropPod
{
    public class CompUseEffect_DropPod : CompUseEffect
    {
        public CompProperties_UseEffectDropPod Props => (CompProperties_UseEffectDropPod)props;

        public override void DoEffect(Pawn user)
        {
            if (Props.thingDef == null)
                return;

            IntVec3 dropSpot;
            Thing thing = ThingMaker.MakeThing(Props.thingDef);

            if (thing != null && DropCellFinder.TryFindDropSpotNear(parent.PositionHeld, parent.MapHeld, out dropSpot, false, false, false))
                TradeUtility.SpawnDropPod(dropSpot, parent.MapHeld, thing);
        }
    }
}
