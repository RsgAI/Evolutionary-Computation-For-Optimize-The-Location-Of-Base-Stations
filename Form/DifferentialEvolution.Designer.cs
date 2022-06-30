namespace BaseStation
{
    partial class DifferentialEvolution
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
            this.maxIterationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.repeatNumeric = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.differentialRate = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.crossverRate = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.mutationCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.crossoverCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.populationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.selectBaseNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.RichTextBox();
            this.radiusNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differentialRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossverRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBaseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // maxIterationNumeric
            // 
            this.maxIterationNumeric.Location = new System.Drawing.Point(260, 307);
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
            this.maxIterationNumeric.TabIndex = 65;
            this.maxIterationNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(183, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 64;
            this.label19.Text = "Max İteration:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(335, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Result";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(338, 26);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(350, 435);
            this.resultText.TabIndex = 62;
            this.resultText.Text = "";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(197, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 46);
            this.startButton.TabIndex = 61;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // repeatNumeric
            // 
            this.repeatNumeric.Location = new System.Drawing.Point(105, 439);
            this.repeatNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatNumeric.Name = "repeatNumeric";
            this.repeatNumeric.Size = new System.Drawing.Size(72, 20);
            this.repeatNumeric.TabIndex = 60;
            this.repeatNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 441);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "Repeat:";
            // 
            // differentialRate
            // 
            this.differentialRate.Location = new System.Drawing.Point(105, 413);
            this.differentialRate.Name = "differentialRate";
            this.differentialRate.Size = new System.Drawing.Size(72, 20);
            this.differentialRate.TabIndex = 58;
            this.differentialRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 415);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Differential Rate(%):";
            // 
            // crossverRate
            // 
            this.crossverRate.Location = new System.Drawing.Point(105, 387);
            this.crossverRate.Name = "crossverRate";
            this.crossverRate.Size = new System.Drawing.Size(72, 20);
            this.crossverRate.TabIndex = 56;
            this.crossverRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Crossover Rate(%):";
            // 
            // mutationCombo
            // 
            this.mutationCombo.FormattingEnabled = true;
            this.mutationCombo.Items.AddRange(new object[] {
            "DE/rand/1",
            "DE/rand/2",
            "DE/best/1",
            "DE/best/2",
            "DE/current-to-best/1"});
            this.mutationCombo.Location = new System.Drawing.Point(105, 360);
            this.mutationCombo.Name = "mutationCombo";
            this.mutationCombo.Size = new System.Drawing.Size(121, 21);
            this.mutationCombo.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Mutation Type:";
            // 
            // crossoverCombo
            // 
            this.crossoverCombo.FormattingEnabled = true;
            this.crossoverCombo.Items.AddRange(new object[] {
            "Classic Crossover"});
            this.crossoverCombo.Location = new System.Drawing.Point(105, 333);
            this.crossoverCombo.Name = "crossoverCombo";
            this.crossoverCombo.Size = new System.Drawing.Size(121, 21);
            this.crossoverCombo.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Crossover Type:";
            // 
            // populationNumeric
            // 
            this.populationNumeric.Location = new System.Drawing.Point(105, 307);
            this.populationNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.populationNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.populationNumeric.Name = "populationNumeric";
            this.populationNumeric.Size = new System.Drawing.Size(72, 20);
            this.populationNumeric.TabIndex = 50;
            this.populationNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Population Size:";
            // 
            // selectBaseNumeric
            // 
            this.selectBaseNumeric.Location = new System.Drawing.Point(105, 281);
            this.selectBaseNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.selectBaseNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectBaseNumeric.Name = "selectBaseNumeric";
            this.selectBaseNumeric.Size = new System.Drawing.Size(72, 20);
            this.selectBaseNumeric.TabIndex = 48;
            this.selectBaseNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Select Base Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Customers";
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(12, 26);
            this.customerText.Name = "customerText";
            this.customerText.ReadOnly = true;
            this.customerText.Size = new System.Drawing.Size(320, 249);
            this.customerText.TabIndex = 45;
            this.customerText.Text = "";
            // 
            // radiusNumeric
            // 
            this.radiusNumeric.Location = new System.Drawing.Point(260, 281);
            this.radiusNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNumeric.Name = "radiusNumeric";
            this.radiusNumeric.Size = new System.Drawing.Size(72, 20);
            this.radiusNumeric.TabIndex = 44;
            this.radiusNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Base Radius:";
            // 
            // DifferentialEvolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 475);
            this.Controls.Add(this.maxIterationNumeric);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.repeatNumeric);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.differentialRate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.crossverRate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.mutationCombo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.crossoverCombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.populationNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.selectBaseNumeric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.radiusNumeric);
            this.Controls.Add(this.label5);
            this.Name = "DifferentialEvolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DifferentialEvolution";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DifferentialEvolution_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differentialRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossverRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBaseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown maxIterationNumeric;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown repeatNumeric;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown differentialRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown crossverRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox mutationCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox crossoverCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown populationNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown selectBaseNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox customerText;
        private System.Windows.Forms.NumericUpDown radiusNumeric;
        private System.Windows.Forms.Label label5;
    }
}