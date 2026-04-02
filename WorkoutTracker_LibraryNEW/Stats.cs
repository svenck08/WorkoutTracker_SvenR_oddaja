using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // staticen razred — nima stanja, samo staticne metode za statistike
    public static class Stats
    {
        // staticna metoda — izracun volumna za zadnjih N dni
        public static double VolumeLastDays(List<WorkoutSession> sessions, int days)
        {
            double sum = 0;
            DateTime from = DateTime.Today.AddDays(-days);

            for (int i = 0; i < sessions.Count; i++)
            {
                if (sessions[i].StartTime >= from)
                    sum += sessions[i].TotalVolume.Value;
            }
            return sum;
        }
        // staticna metoda — vrne referenca na objekt SetEntry z najvisjo tezo
        public static SetEntry BestPR_ByKg(List<WorkoutSession> sessions)
        {
            SetEntry best = null; // referenca na objekt
            for (int i = 0; i < sessions.Count; i++)
            {
                for (int j = 0; j < sessions[i].Sets.Count; j++)
                {
                    SetEntry s = sessions[i].Sets[j];
                    if (best == null || s.Kg > best.Kg) best = s;
                }
            }
            return best;
        }
    }
}
