using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public class Rule_BestPR : StatRule
    {
        public override string Title => "PR";

        public override string Compute(List<WorkoutSession> sessions)
        {
            SetEntry best = null; //objekt, ki bo hranil najboljši set

            for (int i = 0; i < sessions.Count; i++)
            {
                WorkoutSession ws = sessions[i]; //objekt trenutne seje

                for (int j = 0; j < ws.Sets.Count; j++)
                {
                    // uporaba INDEKSERJA: ws[j]
                    SetEntry s = ws[j];

                    if (best == null || s.Kg > best.Kg)
                        best = s;
                }
            }

            if (best == null) return "PR: /";
            return "PR: " + best.ExerciseName + " " + best.Kg + "kg x " + best.Reps; //izpis podatkov iz objektov.
        }
    }
}
