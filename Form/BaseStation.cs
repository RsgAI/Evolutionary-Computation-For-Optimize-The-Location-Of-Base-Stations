using BaseStation.Model;
using System;
using System.Windows.Forms;

namespace BaseStation
{
    //Main Menu
    public partial class BaseStation : Form
    {
        //City Object for use it both Genetic Algorithm and Dİfferential Evolution
        private City city;

        //Constructors
        public BaseStation()
        {
            InitializeComponent();
            this.City = null;

        }
        //End of Constructors

        //Getters and Setters
        internal City City { get => city; set => city = value; }
        //End of Getters and Setters

        //Form Components
        private void InitializeComponent()
        {
            this.geneticButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.RichTextBox();
            this.heightNumeric = new System.Windows.Forms.NumericUpDown();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.generateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNumeric = new System.Windows.Forms.NumericUpDown();
            this.differentialButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // geneticButton
            // 
            this.geneticButton.Enabled = false;
            this.geneticButton.Location = new System.Drawing.Point(12, 310);
            this.geneticButton.Name = "geneticButton";
            this.geneticButton.Size = new System.Drawing.Size(274, 37);
            this.geneticButton.TabIndex = 0;
            this.geneticButton.Text = "Genetic Algorithm";
            this.geneticButton.UseVisualStyleBackColor = true;
            this.geneticButton.Click += new System.EventHandler(this.geneticButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Customers";
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(12, 97);
            this.customerText.Name = "customerText";
            this.customerText.ReadOnly = true;
            this.customerText.Size = new System.Drawing.Size(274, 191);
            this.customerText.TabIndex = 30;
            this.customerText.Text = "";
            // 
            // heightNumeric
            // 
            this.heightNumeric.Location = new System.Drawing.Point(217, 5);
            this.heightNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.heightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNumeric.Name = "heightNumeric";
            this.heightNumeric.Size = new System.Drawing.Size(69, 20);
            this.heightNumeric.TabIndex = 28;
            this.heightNumeric.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // widthNumeric
            // 
            this.widthNumeric.Location = new System.Drawing.Point(95, 5);
            this.widthNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.widthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(69, 20);
            this.widthNumeric.TabIndex = 26;
            this.widthNumeric.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(173, 46);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(113, 23);
            this.generateButton.TabIndex = 25;
            this.generateButton.Text = "Generate New City";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Width:";
            // 
            // customerNumeric
            // 
            this.customerNumeric.Location = new System.Drawing.Point(95, 49);
            this.customerNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.customerNumeric.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.customerNumeric.Name = "customerNumeric";
            this.customerNumeric.Size = new System.Drawing.Size(69, 20);
            this.customerNumeric.TabIndex = 19;
            this.customerNumeric.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // differentialButton
            // 
            this.differentialButton.Enabled = false;
            this.differentialButton.Location = new System.Drawing.Point(12, 356);
            this.differentialButton.Name = "differentialButton";
            this.differentialButton.Size = new System.Drawing.Size(274, 37);
            this.differentialButton.TabIndex = 33;
            this.differentialButton.Text = "Differential Evolution";
            this.differentialButton.UseVisualStyleBackColor = true;
            this.differentialButton.Click += new System.EventHandler(this.differentialButton_Click);
            // 
            // BaseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 405);
            this.Controls.Add(this.differentialButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.heightNumeric);
            this.Controls.Add(this.widthNumeric);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNumeric);
            this.Controls.Add(this.geneticButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Station";
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //Genetic Algorithm Menu Button click event
        private void geneticButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GeneticAlgorithm(this).Show();
        }

        //Differential Evolution Menu Button click event
        private void differentialButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DifferentialEvolution(this).Show();
        }

        //Generate New City Button click event
        private void generateButton_Click(object sender, EventArgs e)
        {
            this.city = CityGenerator.Generate(Convert.ToInt32(this.widthNumeric.Value), Convert.ToInt32(this.heightNumeric.Value), Convert.ToInt32(this.customerNumeric.Value));

            string infoString = "";

            for (int i = 0; i < this.city.CustomerList.Count; i++)
            {
                infoString += this.city.CustomerList[i] + "\n";
            }

            this.customerText.Text = infoString;

            this.geneticButton.Enabled = true;
            this.differentialButton.Enabled = true;
            
        }
        
    }
}
