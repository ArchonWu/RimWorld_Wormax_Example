using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Wormax
{
    public class IngestionOutcomeDoer_RemoveHediff : IngestionOutcomeDoer
    {
        public HediffDef removeThisThing;

        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
        {
            // targetHediff would be gutworm in our case
            var targetHediff = pawn.health.hediffSet.GetFirstHediffOfDef(removeThisThing);
            if (targetHediff != null)
            {
                pawn.health.hediffSet.hediffs.Remove(targetHediff);
            }
        }
    }
}