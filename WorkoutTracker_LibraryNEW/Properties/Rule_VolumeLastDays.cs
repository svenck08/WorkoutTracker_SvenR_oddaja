using System;

public class Class1
{
    public class Rule_VolumeLastDays : StatRule
    {
        private int _days;

        public Rule_VolumeLastDays(int days)
        {
            _days = days;
        }

        public override string Title => "Volumen " + _days + " dni";

        public override string Compute(List<WorkoutSession> sessions)
        {
            TrainingVolume sum = new TrainingVolume(0);
            DateTime from = DateTime.Today.AddDays(-_days);

            for (int i = 0; i < sessions.Count; i++)
            {
                if (sessions[i].StartTime >= from)
                {
                    // Vmesnik preko metode
                    sum = sum + sessions[i].GetVolume();
                }
            }

            return "Volumen " + _days + " dni: " + sum.ToString();
        }
    }
}
