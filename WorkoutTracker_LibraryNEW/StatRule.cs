using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    public abstract class StatRule
    {
        public abstract string Title { get; }
        public abstract string Compute(List<WorkoutSession> sessions);
    }
}
