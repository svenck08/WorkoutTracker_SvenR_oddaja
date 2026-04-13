using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // polimorfizem — Rule_BestPR deduje od abstraktnega StatRule in implementira Compute()
    public class Rule_BestPR : StatRule
    {
        // override abstraktne lastnosti
        public override string Title => "PR";

        // override abstraktne metode — polimorfizem
        public override string Compute(List<WorkoutSession> sessions)
        {
            SetEntry best = null;
            for (int i = 0; i < sessions.Count; i++)
            {
                WorkoutSession ws = sessions[i];
                for (int j = 0; j < ws.Sets.Count; j++)
                {
                    // uporaba int indekserja: ws[j]
                    SetEntry s = ws[j];
                    if (best == null || s.Kg > best.Kg)
                        best = s;
                }
            }
            if (best == null) return "PR: /";

            // uporaba string indekserja — preverimo ali ima ta session se ta set
            // to demonstrira smiselnost iskanja po imenu vaje
            string prIme = best.ExerciseName;
            return "PR: " + prIme + " " + best.Kg + "kg x " + best.Reps;
        }
    }
}
