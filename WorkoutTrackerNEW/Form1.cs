using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutTracker_LibraryNEW;

namespace WorkoutTrackerNEW
{
    public partial class Statistika : Form
    {
        private WorkoutSession active = null;
        private Timer treningTimer = new Timer();
        private List<WorkoutSession> savedSessions = new List<WorkoutSession>();
        private void treningTimer_Tick(object sender, EventArgs e)
        {
            RefreshExerciseUI();
        }
        public Statistika()
        {
            InitializeComponent();
            InitBasics();
            timer1.Interval = 1000;
            timer1.Tick += timer1_tick;
            dgvTreningi.AutoGenerateColumns = true;
            RefreshSavedUI();
        }
        private void btnDodajVajo_Click(object sender, EventArgs e)
        {
            try
            {
                Exercise ex = CreateExerciseFromFields();
                exercises.Add(ex);

                RefreshExerciseUI();
                lblStatus.Text = "Dodana vaja: " + ex.Name;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, "Napaka");
            }
        }
        private List<Exercise> exercises = new List<Exercise>();
        private class SavedWorkoutRow
        {
            public int Index { get; set; }
            public string Start { get; set; }
            public string Duration { get; set; }
            public double Volume { get; set; }
            public int Sets { get; set; }
        }
        private void RefreshSavedUI()
        {
            List<SavedWorkoutRow> rows = new List<SavedWorkoutRow>();
            for (int i = 0; i < savedSessions.Count; i++)
            {
                WorkoutSession ws = savedSessions[i];

                rows.Add(new SavedWorkoutRow
                {
                    Index = i,
                    Start = ws.StartTime.ToString(),
                    Duration = ws.DurationText,
                    Volume = ws.TotalVolume.Value,
                    Sets = ws.Sets.Count
                });
            }
            dgvTreningi.DataSource = null;
            dgvTreningi.DataSource = rows;
            RefreshStatsUI();
        }
        private void InitBasics()
        {
            if (clbMisice.Items.Count == 0)
            {
                clbMisice.Items.Add("Prsa");
                clbMisice.Items.Add("Hrbet");
                clbMisice.Items.Add("Noge");
                clbMisice.Items.Add("Rame");
                clbMisice.Items.Add("Biceps");
                clbMisice.Items.Add("Triceps");
                clbMisice.Items.Add("Trup");
            }
            rdMoc.Checked = true;
            lblCas.Text = "00:00:00";
            lblVolumen.Text = "0";
            dgvSeti.AutoGenerateColumns = true;
            RefreshExerciseUI();
        }
        private ExerciseType GetSelectedType()
        {
            if (rdMoc.Checked) return ExerciseType.Moc;
            if (rdKardio.Checked) return ExerciseType.Kardio;
            return ExerciseType.Regeneracija;
        }
        private List<string> GetSelectedMuscles()
        {
            List<string> muscles = new List<string>();
            for (int i = 0; i < clbMisice.CheckedItems.Count; i++)
                muscles.Add(clbMisice.CheckedItems[i].ToString());
            return muscles;
        }
        private Exercise CreateExerciseFromFields()
        {
            string name = tbImeVaje.Text;
            string device = cbNaprava.Text;
            List<string> muscles = GetSelectedMuscles();
            if (rdMoc.Checked)
                return new StrengthExercise(name, device, muscles);
            ExerciseType type = GetSelectedType();
            return new Exercise(name, device, type, muscles);
        }      
        private void RefreshExerciseUI()
        {
            dgvVaje.AutoGenerateColumns = true;
            dgvVaje.DataSource = null;
            dgvVaje.DataSource = exercises;
            cmbVaja.Items.Clear();
            for (int i = 0; i < exercises.Count; i++)
                cmbVaja.Items.Add(exercises[i]);
            if (cmbVaja.Items.Count > 0 && cmbVaja.SelectedIndex < 0)
                cmbVaja.SelectedIndex = 0;
        }
        private void lbVaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbMisice.SelectedIndex < 0) return;

            Exercise selected = exercises[clbMisice.SelectedIndex];

            tbImeVaje.Text = selected.Name;
            cbNaprava.Text = selected.Device;
            rdMoc.Checked = selected.Type == ExerciseType.Moc;
            rdKardio.Checked = selected.Type == ExerciseType.Kardio;
            rdRegeneracija.Checked = selected.Type == ExerciseType.Regeneracija;
            for (int i = 0; i < clbMisice.Items.Count; i++)
                clbMisice.SetItemChecked(i, false);

            for (int m = 0; m < selected.Muscles.Count; m++)
            {
                for (int i = 0; i < clbMisice.Items.Count; i++)
                {
                    if (clbMisice.Items[i].ToString() == selected.Muscles[m])
                        clbMisice.SetItemChecked(i, true);
                }
            }
        }
        private void RefreshWorkoutUI()
        {
            if (active == null)
            {
                lblCas.Text = "00:00:00";
                lblVolumen.Text = "0";
                dgvSeti.DataSource = null;
                return;
            }
            lblCas.Text = active.DurationText;
            lblVolumen.Text = active.TotalVolume.ToString();
            dgvSeti.DataSource = null;
            dgvSeti.DataSource = active.Sets;
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            RefreshWorkoutUI();
        }
        private void RefreshStatsUI()
        {

            List<StatRule> rules = new List<StatRule>();
            rules.Add(new Rule_BestPR());
            rules.Add(new Rule_VolumeLastDays(7));
            rules.Add(new Rule_VolumeLastDays(30));   
            label9.Text = rules[0].Compute(savedSessions);
            string text = "";
            text += rules[1].Compute(savedSessions) + Environment.NewLine;
            text += rules[2].Compute(savedSessions) + Environment.NewLine;
            text += "Treningov: " + savedSessions.Count;
            label10.Text = text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            active = new WorkoutSession();
            active.Start();
            timer1.Start();         
            RefreshWorkoutUI();
            lblStatus.Text = "Trening se je začel.";
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (active == null) return;
            if (!active.IsRunning) return;
            if (active.IsPaused) active.Resume();
            else active.Pause();
            RefreshWorkoutUI();
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (active == null) return;
            if (!active.IsRunning) return;
            active.End();
            timer1.Stop();
            RefreshWorkoutUI();
            lblStatus.Text = "Trening končan.";
        }
        private void btnAddSet_Click(object sender, EventArgs e)
        {
            if (active == null || !active.IsRunning)
            {
                MessageBox.Show("Najprej klikni Start.");
                return;
            }
            if (cmbVaja.SelectedIndex < 0)
            {
                MessageBox.Show("Najprej dodaj vaje in izberi vajo.");
                return;
            }
            try
            {
                Exercise ex = (Exercise)cmbVaja.SelectedItem;

                double kg = (double)numKg.Value;
                int reps = (int)numReps.Value;
                int rpe = (int)numRPE.Value;

                SetEntry set = new SetEntry(ex.Name, kg, reps, rpe);
                active.Sets.Add(set);

                RefreshWorkoutUI();
                lblStatus.Text = "Set dodan.";
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, "Napaka");
            }
        }
        private void btnUrediVajo_Click(object sender, EventArgs e)
        {
            if (clbMisice.SelectedIndex < 0)
            {
                MessageBox.Show("Najprej izberi vajo.");
                return;
            }
            try
            {
                Exercise selected = exercises[clbMisice.SelectedIndex];
                string name = tbImeVaje.Text;
                string device = cbNaprava.Text;
                ExerciseType type = GetSelectedType();
                List<string> muscles = GetSelectedMuscles();
                selected.Update(name, device, type, muscles);
                RefreshExerciseUI();
                lblStatus.Text = "Vaja posodobljena.";
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, "Napaka");
            }
        }
        private void btnIzbrisiVajo_Click(object sender, EventArgs e)
        {
            if (clbMisice.SelectedIndex < 0)
            {
                MessageBox.Show("Najprej izberi vajo.");
                return;
            }
            try
            {
                Exercise selected = exercises[clbMisice.SelectedIndex];
                string name = tbImeVaje.Text;
                string device = cbNaprava.Text;
                ExerciseType type = GetSelectedType();
                List<string> muscles = GetSelectedMuscles();
                selected.Update(name, device, type, muscles);
                RefreshExerciseUI();
                lblStatus.Text = "Vaja posodobljena.";
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, "Napaka");
            }
        }
        private void btnSaveWorkout_Click(object sender, EventArgs e)
        {
            if (active == null)
            {
                MessageBox.Show("Ni aktivnega treninga.");
                return;
            }
            if (active.IsRunning)
            {
                active.End();
                timer1.Stop();
                RefreshWorkoutUI();
            }
            if (active.Sets.Count == 0)
            {
                MessageBox.Show("Trening nima nobenega seta.");
                return;
            }
            savedSessions.Add(active);
            active = null;
            lblStatus.Text = "Trening shranjen.";
            RefreshSavedUI();
        }

        private void btnDeleteWorkout_Click(object sender, EventArgs e)
        {
            if (dgvTreningi.CurrentRow == null)
            {
                MessageBox.Show("Najprej izberi trening v tabeli.");
                return;
            }
            int idx = dgvTreningi.CurrentRow.Index;
            if (idx < 0 || idx >= savedSessions.Count)
            {
                MessageBox.Show("Napačen izbor.");
                return;
            }
            savedSessions.RemoveAt(idx);
            lblStatus.Text = "Trening izbrisan.";
            RefreshSavedUI();
        }
    }
}
