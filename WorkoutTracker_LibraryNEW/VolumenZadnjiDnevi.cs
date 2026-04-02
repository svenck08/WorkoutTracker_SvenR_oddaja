using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_LibraryNEW
{
    // polimorfizem — Rule_VolumeLastDays deduje od abstraktnega StatRule
    public class Rule_VolumeLastDays : StatRule
    {
        private int _days;
        // konstruktor s parametrom
        public Rule_VolumeLastDays(int days)
        {
            _days = days;
        }
        // override abstraktne lastnosti
        public override string Title => "Volumen " + _days + " dni";

        public override string Compute(List<WorkoutSession> sessions)
        {
            TrainingVolume sum = new TrainingVolume(0);
            DateTime from = DateTime.Today.AddDays(-_days);

            for (int i = 0; i < sessions.Count; i++)
            {
                if (sessions[i].StartTime >= from)
                {
                    // uporaba vmesnika kot tip spremenljivke
                    IHasVolume volumeProvider = sessions[i];
                    sum = sum + volumeProvider.GetVolume();
                }
            }
            // uporaba preoblozenih primerjalnih operatorjev > na TrainingVolume
            if (sum > new TrainingVolume(0))
                return "Volumen " + _days + " dni: " + sum.ToString();
            else
                return "Volumen " + _days + " dni: ni podatkov";
        }
    }
}
