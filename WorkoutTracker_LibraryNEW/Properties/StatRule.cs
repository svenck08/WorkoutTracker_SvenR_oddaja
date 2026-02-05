using System;

public class Class1
{
    public abstract class StatRule
    {
        public abstract string Title { get; }
        public abstract string Compute(List<WorkoutSession> sessions);
    }
}
