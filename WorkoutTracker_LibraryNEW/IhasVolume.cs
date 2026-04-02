using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // vmesnik — implementirajo ga WorkoutSession in SetEntry
    public interface IHasVolume
    {
        TrainingVolume GetVolume();
    }
}
