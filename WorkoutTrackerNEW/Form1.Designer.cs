namespace WorkoutTrackerNEW
{
    partial class Statistika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCas = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.cmbVaja = new System.Windows.Forms.ComboBox();
            this.numKg = new System.Windows.Forms.NumericUpDown();
            this.numReps = new System.Windows.Forms.NumericUpDown();
            this.numRPE = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvSeti = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVaje = new System.Windows.Forms.DataGridView();
            this.tbImeVaje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNaprava = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clbMisice = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdMoc = new System.Windows.Forms.RadioButton();
            this.rdKardio = new System.Windows.Forms.RadioButton();
            this.rdRegeneracija = new System.Windows.Forms.RadioButton();
            this.btnDodajVajo = new System.Windows.Forms.Button();
            this.btnUrediVajo = new System.Windows.Forms.Button();
            this.btnIzbrisiVajo = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTreningi = new System.Windows.Forms.DataGridView();
            this.btnSaveWorkout = new System.Windows.Forms.Button();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.btnAddSet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeti)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaje)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreningi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSet);
            this.groupBox1.Controls.Add(this.lblVolumen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvSeti);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numRPE);
            this.groupBox1.Controls.Add(this.numReps);
            this.groupBox1.Controls.Add(this.numKg);
            this.groupBox1.Controls.Add(this.cmbVaja);
            this.groupBox1.Controls.Add(this.btnEnd);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lblCas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutni Trening";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Čas Treninga:";
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.Location = new System.Drawing.Point(6, 106);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(35, 13);
            this.lblCas.TabIndex = 1;
            this.lblCas.Text = "label2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(598, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Začetek";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(598, 147);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pavza";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(598, 191);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Končaj";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // cmbVaja
            // 
            this.cmbVaja.FormattingEnabled = true;
            this.cmbVaja.Location = new System.Drawing.Point(6, 48);
            this.cmbVaja.Name = "cmbVaja";
            this.cmbVaja.Size = new System.Drawing.Size(121, 21);
            this.cmbVaja.TabIndex = 5;
            // 
            // numKg
            // 
            this.numKg.Location = new System.Drawing.Point(156, 48);
            this.numKg.Name = "numKg";
            this.numKg.Size = new System.Drawing.Size(120, 20);
            this.numKg.TabIndex = 6;
            // 
            // numReps
            // 
            this.numReps.Location = new System.Drawing.Point(297, 49);
            this.numReps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReps.Name = "numReps";
            this.numReps.Size = new System.Drawing.Size(120, 20);
            this.numReps.TabIndex = 7;
            this.numReps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRPE
            // 
            this.numRPE.Location = new System.Drawing.Point(445, 49);
            this.numRPE.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRPE.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numRPE.Name = "numRPE";
            this.numRPE.Size = new System.Drawing.Size(120, 20);
            this.numRPE.TabIndex = 8;
            this.numRPE.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Izbira Vaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Teža";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ponovitve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "RPE";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // dgvSeti
            // 
            this.dgvSeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeti.Location = new System.Drawing.Point(27, 147);
            this.dgvSeti.Name = "dgvSeti";
            this.dgvSeti.Size = new System.Drawing.Size(538, 175);
            this.dgvSeti.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Skupni Volumen";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(148, 106);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(35, 13);
            this.lblVolumen.TabIndex = 15;
            this.lblVolumen.Text = "label7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btnIzbrisiVajo);
            this.groupBox2.Controls.Add(this.btnUrediVajo);
            this.groupBox2.Controls.Add(this.btnDodajVajo);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.clbMisice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbNaprava);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbImeVaje);
            this.groupBox2.Controls.Add(this.dgvVaje);
            this.groupBox2.Location = new System.Drawing.Point(41, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vse Vaje";
            // 
            // dgvVaje
            // 
            this.dgvVaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaje.Location = new System.Drawing.Point(27, 150);
            this.dgvVaje.Name = "dgvVaje";
            this.dgvVaje.Size = new System.Drawing.Size(538, 162);
            this.dgvVaje.TabIndex = 0;
            // 
            // tbImeVaje
            // 
            this.tbImeVaje.Location = new System.Drawing.Point(27, 42);
            this.tbImeVaje.Name = "tbImeVaje";
            this.tbImeVaje.Size = new System.Drawing.Size(122, 20);
            this.tbImeVaje.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ime Vaje";
            // 
            // cbNaprava
            // 
            this.cbNaprava.FormattingEnabled = true;
            this.cbNaprava.Items.AddRange(new object[] {
            "Proste uteži",
            "Bench",
            "Dips",
            "Kabel",
            "Smith Machine",
            "Stroj",
            "Tekalna steza",
            "Kolo",
            "Veslač"});
            this.cbNaprava.Location = new System.Drawing.Point(183, 42);
            this.cbNaprava.Name = "cbNaprava";
            this.cbNaprava.Size = new System.Drawing.Size(121, 21);
            this.cbNaprava.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mašina";
            // 
            // clbMisice
            // 
            this.clbMisice.FormattingEnabled = true;
            this.clbMisice.Items.AddRange(new object[] {
            "Prsa",
            "Noge",
            "Hrbet",
            "Rame",
            "Biceps",
            "Triceps",
            "Zadnjica"});
            this.clbMisice.Location = new System.Drawing.Point(336, 35);
            this.clbMisice.Name = "clbMisice";
            this.clbMisice.Size = new System.Drawing.Size(229, 109);
            this.clbMisice.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdRegeneracija);
            this.groupBox3.Controls.Add(this.rdKardio);
            this.groupBox3.Controls.Add(this.rdMoc);
            this.groupBox3.Location = new System.Drawing.Point(598, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 109);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izvedba";
            // 
            // rdMoc
            // 
            this.rdMoc.AutoSize = true;
            this.rdMoc.Location = new System.Drawing.Point(7, 20);
            this.rdMoc.Name = "rdMoc";
            this.rdMoc.Size = new System.Drawing.Size(46, 17);
            this.rdMoc.TabIndex = 0;
            this.rdMoc.TabStop = true;
            this.rdMoc.Text = "Moč";
            this.rdMoc.UseVisualStyleBackColor = true;
            // 
            // rdKardio
            // 
            this.rdKardio.AutoSize = true;
            this.rdKardio.Location = new System.Drawing.Point(7, 44);
            this.rdKardio.Name = "rdKardio";
            this.rdKardio.Size = new System.Drawing.Size(55, 17);
            this.rdKardio.TabIndex = 1;
            this.rdKardio.TabStop = true;
            this.rdKardio.Text = "Kardio";
            this.rdKardio.UseVisualStyleBackColor = true;
            // 
            // rdRegeneracija
            // 
            this.rdRegeneracija.AutoSize = true;
            this.rdRegeneracija.Location = new System.Drawing.Point(7, 68);
            this.rdRegeneracija.Name = "rdRegeneracija";
            this.rdRegeneracija.Size = new System.Drawing.Size(88, 17);
            this.rdRegeneracija.TabIndex = 2;
            this.rdRegeneracija.TabStop = true;
            this.rdRegeneracija.Text = "Regeneracija";
            this.rdRegeneracija.UseVisualStyleBackColor = true;
            // 
            // btnDodajVajo
            // 
            this.btnDodajVajo.Location = new System.Drawing.Point(598, 151);
            this.btnDodajVajo.Name = "btnDodajVajo";
            this.btnDodajVajo.Size = new System.Drawing.Size(95, 23);
            this.btnDodajVajo.TabIndex = 7;
            this.btnDodajVajo.Text = "Dodaj vajo";
            this.btnDodajVajo.UseVisualStyleBackColor = true;
            this.btnDodajVajo.Click += new System.EventHandler(this.btnDodajVajo_Click);
            // 
            // btnUrediVajo
            // 
            this.btnUrediVajo.Location = new System.Drawing.Point(598, 197);
            this.btnUrediVajo.Name = "btnUrediVajo";
            this.btnUrediVajo.Size = new System.Drawing.Size(95, 23);
            this.btnUrediVajo.TabIndex = 8;
            this.btnUrediVajo.Text = "Spremeni vajo";
            this.btnUrediVajo.UseVisualStyleBackColor = true;
            this.btnUrediVajo.Click += new System.EventHandler(this.btnUrediVajo_Click);
            // 
            // btnIzbrisiVajo
            // 
            this.btnIzbrisiVajo.Location = new System.Drawing.Point(598, 243);
            this.btnIzbrisiVajo.Name = "btnIzbrisiVajo";
            this.btnIzbrisiVajo.Size = new System.Drawing.Size(95, 23);
            this.btnIzbrisiVajo.TabIndex = 9;
            this.btnIzbrisiVajo.Text = "Izbriši vajo";
            this.btnIzbrisiVajo.UseVisualStyleBackColor = true;
            this.btnIzbrisiVajo.Click += new System.EventHandler(this.btnIzbrisiVajo_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 79);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStat);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnDeleteWorkout);
            this.groupBox4.Controls.Add(this.btnSaveWorkout);
            this.groupBox4.Controls.Add(this.dgvTreningi);
            this.groupBox4.Location = new System.Drawing.Point(804, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 328);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistika";
            // 
            // dgvTreningi
            // 
            this.dgvTreningi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreningi.Location = new System.Drawing.Point(27, 138);
            this.dgvTreningi.Name = "dgvTreningi";
            this.dgvTreningi.Size = new System.Drawing.Size(402, 175);
            this.dgvTreningi.TabIndex = 0;
            // 
            // btnSaveWorkout
            // 
            this.btnSaveWorkout.Location = new System.Drawing.Point(330, 44);
            this.btnSaveWorkout.Name = "btnSaveWorkout";
            this.btnSaveWorkout.Size = new System.Drawing.Size(99, 23);
            this.btnSaveWorkout.TabIndex = 1;
            this.btnSaveWorkout.Text = "Shrani Trening";
            this.btnSaveWorkout.UseVisualStyleBackColor = true;
            this.btnSaveWorkout.Click += new System.EventHandler(this.btnSaveWorkout_Click);
            // 
            // btnDeleteWorkout
            // 
            this.btnDeleteWorkout.Location = new System.Drawing.Point(330, 73);
            this.btnDeleteWorkout.Name = "btnDeleteWorkout";
            this.btnDeleteWorkout.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteWorkout.TabIndex = 2;
            this.btnDeleteWorkout.Text = "Izbrisi vajo";
            this.btnDeleteWorkout.UseVisualStyleBackColor = true;
            this.btnDeleteWorkout.Click += new System.EventHandler(this.btnDeleteWorkout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "label9";
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(24, 39);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(41, 13);
            this.lblStat.TabIndex = 4;
            this.lblStat.Text = "label10";
            // 
            // btnAddSet
            // 
            this.btnAddSet.Location = new System.Drawing.Point(598, 44);
            this.btnAddSet.Name = "btnAddSet";
            this.btnAddSet.Size = new System.Drawing.Size(75, 23);
            this.btnAddSet.TabIndex = 16;
            this.btnAddSet.Text = "Dodaj set";
            this.btnAddSet.UseVisualStyleBackColor = true;
            this.btnAddSet.Click += new System.EventHandler(this.btnAddSet_Click);
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 729);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistika";
            this.Text = "Naprava";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaje)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreningi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRPE;
        private System.Windows.Forms.NumericUpDown numReps;
        private System.Windows.Forms.NumericUpDown numKg;
        private System.Windows.Forms.ComboBox cmbVaja;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSeti;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvVaje;
        private System.Windows.Forms.ComboBox cbNaprava;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbImeVaje;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdRegeneracija;
        private System.Windows.Forms.RadioButton rdKardio;
        private System.Windows.Forms.RadioButton rdMoc;
        private System.Windows.Forms.CheckedListBox clbMisice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnIzbrisiVajo;
        private System.Windows.Forms.Button btnUrediVajo;
        private System.Windows.Forms.Button btnDodajVajo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.Button btnSaveWorkout;
        private System.Windows.Forms.DataGridView dgvTreningi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Button btnAddSet;
    }
}

