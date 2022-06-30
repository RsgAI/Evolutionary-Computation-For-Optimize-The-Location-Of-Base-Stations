using BaseStation.Model;
using BaseStation.Problem;
using BaseStation.Solvent.GeneticAlgorithm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseStation
{
    //Genetic Algorithm Menu
    public partial class GeneticAlgorithm : Form
    {
        /*
        * BaseStation Object for return Main Menu
        * City Object for solve the problem
        * totalGeneration for hold total generation size
        * totalTime for hold execution time
        * 
        */
        private BaseStation parent;
        private City city;

        private int totalGeneration;
        private double totalTime;

        //Constructors
        public GeneticAlgorithm(BaseStation parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.city = parent.City;
            this.FillForm();
            this.selectCombo.SelectedIndex = 0;
            this.crossoverCombo.SelectedIndex = 1;
            this.mutationCombo.SelectedIndex = 1;
        }
        //End of Constructors

        //Form Closed event
        private void GeneticAlgorithm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        //Generate Candidate Stations Button click event
        private void generateButton_Click(object sender, EventArgs e)
        {
            this.city.CandidateBaseList = CityGenerator.RandomBase(Convert.ToInt32(this.baseNumeric.Value), this.city, new Random());
            this.FillForm();

        }

        //Combobox selectedIndexChanged event for display or hide tournament panel
        private void selectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.selectCombo.SelectedIndex == 1)
                this.tournamentPanel.Show();
            else
                this.tournamentPanel.Hide();
        }

        //Start Button click event
        private void startButton_Click(object sender, EventArgs e)
        {
            this.city.BaseRadius = Convert.ToInt32(this.radiusNumeric.Value);
            Selection selection = null;
            if (this.selectCombo.SelectedIndex == 0)
                selection = new RouletteWheel();
            else if (this.selectCombo.SelectedIndex == 1)
                selection = new Tournament(Convert.ToInt32(this.tournamentNumeric.Value));

            Crossover crossover = null;
            if (this.crossoverCombo.SelectedIndex == 0)
                crossover = new ClassicCrossover();
            else if (this.crossoverCombo.SelectedIndex == 1)
                crossover = new Order1Crossover();

            Mutation mutation = null;
            if (this.mutationCombo.SelectedIndex == 0)
                mutation = new ClassicMutation(Convert.ToDouble(this.generalMutationNumeric.Value) / 100,
                    Convert.ToDouble(this.individualMutationNumeric.Value) / 100);
            else if (this.mutationCombo.SelectedIndex == 1)
                mutation = new StepMutation(Convert.ToDouble(this.generalMutationNumeric.Value) / 100,
                    Convert.ToDouble(this.individualMutationNumeric.Value) / 100);

            BaseLocation problem = new BaseLocation(this.city, Convert.ToInt32(this.selectBaseNumeric.Value));

            int populationSize = Convert.ToInt32(this.populationNumeric.Value), eliteSize = Convert.ToInt32(this.eliteNumeric.Value),
                maximumIteration = Convert.ToInt32(this.maxIterationNumeric.Value), repeatSize = Convert.ToInt32(this.repeatNumeric.Value);

            string result = "";

            this.resultText.Text = "";


            this.totalGeneration = 0;
            this.totalTime = 0;

            Evolution evolution = null;
            List<int> resultList = new List<int>();
            for (int i = 0; i < repeatSize; i++) {

                evolution = new Evolution(problem, crossover, mutation, selection, populationSize, eliteSize, maximumIteration);

                evolution.Start();

                resultList.Add(evolution.Population.List[0].Fitness);
                this.totalGeneration += evolution.GenerationCount;
                this.totalTime += (evolution.EndTime - evolution.StartTime).TotalMilliseconds;

                result += this.ResultString(evolution, i + 1);
            }
            if (resultList.Count > 1)
            {
                resultList = this.MergeSort(resultList, 0, resultList.Count - 1);
                double mean = this.MyMean(resultList);
                double stdev = this.MyStandardDeviation(resultList, mean);
                double median = 0;
                int middle = resultList.Count / 2;
                if (resultList.Count % 2 == 0)
                {
                    median = (resultList[middle] + resultList[middle - 1]) / 2.0;
                }
                else
                {
                    median = resultList[middle];
                }
                result += "******************************* Avarage *******************************";
                result += "\nMean: " + mean;
                result += "\nMedian: " + median;
                result += "\nStandard Deviation: " + stdev;
                result += "\nBest: " + resultList[0];
                result += "\nWorst: " + resultList[resultList.Count - 1];
                result += "\nGeneration: " + this.totalGeneration / (double)repeatSize;
                result += "\nTime: " + this.totalTime / (double)repeatSize + " ms";
                result += "\n\n";
            }
            this.resultText.Text = result;

        }

        //Method to generate result string
        private string ResultString(Evolution evolution, int count)
        {

            string result = "******************************* " + count + " *******************************";
            result += "\nSelected Locations:";

            for (int i = 0; i < evolution.Population.List[0].Chromosome.Length; i++)
            {
                result += "\n\t" + evolution.Problem.City.CandidateBaseList[evolution.Population.List[0].Chromosome[i]];
            }

            result += "\n\nFitness (Persons Not In Any Base): " + evolution.Population.List[0].Fitness;
            result += "\nGeneration: " + evolution.GenerationCount;
            result += "\nTime: " + (evolution.EndTime - evolution.StartTime).TotalMilliseconds + " ms";
            result += "\n\n";

            return result;
        }

        //Method to fill Form
        private void FillForm() {
            string infoString = "";

            for (int i = 0; i < this.city.CustomerList.Count; i++)
            {
                infoString += this.city.CustomerList[i] + "\n";
            }

            this.customerText.Text = infoString;
            
            if (this.city.CandidateBaseList != null && this.city.CandidateBaseList.Count >= this.baseNumeric.Minimum)
            {
                this.selectBaseNumeric.Maximum = this.city.CandidateBaseList.Count - 1;

                infoString = "";

                for (int i = 0; i < this.city.CandidateBaseList.Count; i++)
                {
                    infoString += this.city.CandidateBaseList[i] + "\n";
                }

                this.candidateBaseText.Text = infoString;


                this.startButton.Enabled = true;
            }
        }

        //Method to Calculate Mean
        private double MyMean(List<int> list)
        {
            double result = 0;
            for(int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }

            return result / list.Count;

        }

        //Method to Calculate Standard Deviation
        private double MyStandardDeviation(List<int> list, double mean)
        {
            double result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                result += Math.Pow(list[i] - mean, 2);
            }

            return Math.Sqrt(result / (list.Count - 1));

        }

        //Merge Sort Method
        private List<int> MergeSort(List<int> list, int first, int last)
        {

            List<int> result;
            int middle = (first + last) / 2;
            if (first != last)
            {
                List<int> left = MergeSort(list, first, middle);
                List<int> right = MergeSort(list, middle + 1, last);
                result = Merge(left, right);
            }
            else
            {
                result = new List<int>();
                result.Add(list[first]);
            }
            return result;
        }

        //Merge Method for Merge Sort
        private List<int> Merge(List<int> left, List<int> right)
        {

            List<int> result = new List<int>();
            int rightIndex = 0, leftIndex = 0;


            while (leftIndex < left.Count && rightIndex < right.Count)
            {

                if (right[rightIndex] < left[leftIndex])
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
                else
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }

            }

            while (leftIndex < left.Count)
                result.Add(left[leftIndex++]);

            while (rightIndex < right.Count)
                result.Add(right[rightIndex++]);

            return result;

        }
    }
}
