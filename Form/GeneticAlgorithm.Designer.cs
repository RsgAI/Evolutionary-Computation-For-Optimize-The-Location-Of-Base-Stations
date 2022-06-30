namespace BaseStation
{
    partial class GeneticAlgorithm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.baseNumeric = new System.Windows.Forms.NumericUpDown();
            this.radiusNumeric = new System.Windows.Forms.NumericUpDown();
            this.customerText = new System.Windows.Forms.RichTextBox();
            this.candidateBaseText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectBaseNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.populationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.eliteNumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.selectCombo = new System.Windows.Forms.ComboBox();
            this.tournamentPanel = new System.Windows.Forms.Panel();
            this.tournamentNumeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.crossoverCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mutationCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.generalMutationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.individualMutationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.repeatNumeric = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.maxIterationNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.baseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBaseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteNumeric)).BeginInit();
            this.tournamentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalMutationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualMutationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Base Radius:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(516, 2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(63, 20);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // baseNumeric
            // 
            this.baseNumeric.Location = new System.Drawing.Point(444, 2);
            this.baseNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.baseNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.baseNumeric.Name = "baseNumeric";
            this.baseNumeric.Size = new System.Drawing.Size(66, 20);
            this.baseNumeric.TabIndex = 12;
            this.baseNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radiusNumeric
            // 
            this.radiusNumeric.Location = new System.Drawing.Point(325, 280);
            this.radiusNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNumeric.Name = "radiusNumeric";
            this.radiusNumeric.Size = new System.Drawing.Size(72, 20);
            this.radiusNumeric.TabIndex = 14;
            this.radiusNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(12, 25);
            this.customerText.Name = "customerText";
            this.customerText.ReadOnly = true;
            this.customerText.Size = new System.Drawing.Size(277, 249);
            this.customerText.TabIndex = 15;
            this.customerText.Text = "";
            // 
            // candidateBaseText
            // 
            this.candidateBaseText.Location = new System.Drawing.Point(295, 25);
            this.candidateBaseText.Name = "candidateBaseText";
            this.candidateBaseText.ReadOnly = true;
            this.candidateBaseText.Size = new System.Drawing.Size(284, 249);
            this.candidateBaseText.TabIndex = 16;
            this.candidateBaseText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Candidate Bases";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Select Base Size:";
            // 
            // selectBaseNumeric
            // 
            this.selectBaseNumeric.Location = new System.Drawing.Point(108, 280);
            this.selectBaseNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectBaseNumeric.Name = "selectBaseNumeric";
            this.selectBaseNumeric.Size = new System.Drawing.Size(72, 20);
            this.selectBaseNumeric.TabIndex = 20;
            this.selectBaseNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Population Size:";
            // 
            // populationNumeric
            // 
            this.populationNumeric.Location = new System.Drawing.Point(507, 280);
            this.populationNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.populationNumeric.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.populationNumeric.Name = "populationNumeric";
            this.populationNumeric.Size = new System.Drawing.Size(72, 20);
            this.populationNumeric.TabIndex = 22;
            this.populationNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Elite Size:";
            // 
            // eliteNumeric
            // 
            this.eliteNumeric.Location = new System.Drawing.Point(507, 306);
            this.eliteNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.eliteNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.eliteNumeric.Name = "eliteNumeric";
            this.eliteNumeric.Size = new System.Drawing.Size(72, 20);
            this.eliteNumeric.TabIndex = 24;
            this.eliteNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Selection Type:";
            // 
            // selectCombo
            // 
            this.selectCombo.FormattingEnabled = true;
            this.selectCombo.Items.AddRange(new object[] {
            "Roulette Wheel",
            "Tournament"});
            this.selectCombo.Location = new System.Drawing.Point(108, 306);
            this.selectCombo.Name = "selectCombo";
            this.selectCombo.Size = new System.Drawing.Size(121, 21);
            this.selectCombo.TabIndex = 26;
            this.selectCombo.SelectedIndexChanged += new System.EventHandler(this.selectCombo_SelectedIndexChanged);
            // 
            // tournamentPanel
            // 
            this.tournamentPanel.Controls.Add(this.tournamentNumeric);
            this.tournamentPanel.Controls.Add(this.label12);
            this.tournamentPanel.Location = new System.Drawing.Point(235, 306);
            this.tournamentPanel.Name = "tournamentPanel";
            this.tournamentPanel.Size = new System.Drawing.Size(170, 21);
            this.tournamentPanel.TabIndex = 27;
            this.tournamentPanel.Visible = false;
            // 
            // tournamentNumeric
            // 
            this.tournamentNumeric.Location = new System.Drawing.Point(95, 1);
            this.tournamentNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tournamentNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tournamentNumeric.Name = "tournamentNumeric";
            this.tournamentNumeric.Size = new System.Drawing.Size(72, 20);
            this.tournamentNumeric.TabIndex = 27;
            this.tournamentNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tournament Size:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Crossover Type:";
            // 
            // crossoverCombo
            // 
            this.crossoverCombo.FormattingEnabled = true;
            this.crossoverCombo.Items.AddRange(new object[] {
            "Classic Crossover",
            "Order 1 Crossover"});
            this.crossoverCombo.Location = new System.Drawing.Point(108, 333);
            this.crossoverCombo.Name = "crossoverCombo";
            this.crossoverCombo.Size = new System.Drawing.Size(121, 21);
            this.crossoverCombo.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(235, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Mutation Type:";
            // 
            // mutationCombo
            // 
            this.mutationCombo.FormattingEnabled = true;
            this.mutationCombo.Items.AddRange(new object[] {
            "Classic Mutation",
            "Step Mutation"});
            this.mutationCombo.Location = new System.Drawing.Point(325, 333);
            this.mutationCombo.Name = "mutationCombo";
            this.mutationCombo.Size = new System.Drawing.Size(121, 21);
            this.mutationCombo.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "General Mutation Rate(%):";
            // 
            // generalMutationNumeric
            // 
            this.generalMutationNumeric.Location = new System.Drawing.Point(149, 360);
            this.generalMutationNumeric.Name = "generalMutationNumeric";
            this.generalMutationNumeric.Size = new System.Drawing.Size(72, 20);
            this.generalMutationNumeric.TabIndex = 33;
            this.generalMutationNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(227, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Individual Mutation Rate(%):";
            // 
            // individualMutationNumeric
            // 
            this.individualMutationNumeric.Location = new System.Drawing.Point(366, 360);
            this.individualMutationNumeric.Name = "individualMutationNumeric";
            this.individualMutationNumeric.Size = new System.Drawing.Size(72, 20);
            this.individualMutationNumeric.TabIndex = 35;
            this.individualMutationNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(227, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Repeat:";
            // 
            // repeatNumeric
            // 
            this.repeatNumeric.Location = new System.Drawing.Point(366, 386);
            this.repeatNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatNumeric.Name = "repeatNumeric";
            this.repeatNumeric.Size = new System.Drawing.Size(72, 20);
            this.repeatNumeric.TabIndex = 37;
            this.repeatNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(444, 360);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 46);
            this.startButton.TabIndex = 38;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(585, 25);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(350, 381);
            this.resultText.TabIndex = 39;
            this.resultText.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(582, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Result";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 388);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Max Iteration:";
            // 
            // maxIterationNumeric
            // 
            this.maxIterationNumeric.Location = new System.Drawing.Point(149, 386);
            this.maxIterationNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxIterationNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxIterationNumeric.Name = "maxIterationNumeric";
            this.maxIterationNumeric.Size = new System.Drawing.Size(72, 20);
            this.maxIterationNumeric.TabIndex = 42;
            this.maxIterationNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // GeneticAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 418);
            this.Controls.Add(this.maxIterationNumeric);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.repeatNumeric);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.individualMutationNumeric);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.generalMutationNumeric);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.mutationCombo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.crossoverCombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tournamentPanel);
            this.Controls.Add(this.selectCombo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.eliteNumeric);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.populationNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.selectBaseNumeric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.candidateBaseText);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.radiusNumeric);
            this.Controls.Add(this.baseNumeric);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GeneticAlgorithm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneticAlgorithm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneticAlgorithm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.baseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBaseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteNumeric)).EndInit();
            this.tournamentPanel.ResumeLayout(false);
            this.tournamentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalMutationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualMutationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.NumericUpDown baseNumeric;
        private System.Windows.Forms.NumericUpDown radiusNumeric;
        private System.Windows.Forms.RichTextBox customerText;
        private System.Windows.Forms.RichTextBox candidateBaseText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown selectBaseNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown populationNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown eliteNumeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox selectCombo;
        private System.Windows.Forms.Panel tournamentPanel;
        private System.Windows.Forms.NumericUpDown tournamentNumeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox crossoverCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox mutationCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown generalMutationNumeric;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown individualMutationNumeric;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown repeatNumeric;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown maxIterationNumeric;
    }
}