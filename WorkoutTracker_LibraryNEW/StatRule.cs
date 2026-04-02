using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // abstraktni razred — definira pogodbo za statisticna pravila
    // polimorfizem — dedujeta ga Rule_BestPR in Rule_VolumeLastDays
    public abstract class StatRule
    {
        // abstraktna lastnost — vsak podrazred mora definirati svoj naslov
        public abstract string Title { get; }
        // abstraktna metoda — vsak podrazred implementira svoj izracun
        public abstract string Compute(List<WorkoutSession> sessions);
    }
}
