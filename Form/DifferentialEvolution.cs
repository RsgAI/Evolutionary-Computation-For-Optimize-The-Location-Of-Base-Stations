using BaseStation.Model;
using BaseStation.Problem;
using BaseStation.Solvent.DifferentialEvolution;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseStation
{
    //Differential Evolution Menu
    public partial class DifferentialEvolution : Form
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
        public DifferentialEvolution(BaseStation parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.city = parent.City;
            this.FillForm();
            this.crossoverCombo.SelectedIndex = 0;
            this.mutationCombo.SelectedIndex = 0;
        }
        //End of Constructors

        //Form Closed event
        private void DifferentialEvolution_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        //Start Button click event
        private void startButton_Click(object sender, EventArgs e)
        {
            this.city.BaseRadius = Convert.ToInt32(this.radiusNumeric.Value);
            
            DECrossover crossover = null;
            if (this.crossoverCombo.SelectedIndex == 0)
                crossover = new DECrossoverType1(Convert.ToInt32(this.crossverRate.Value) / 100.0);

            DEMutation mutation = null;
            if (this.mutationCombo.SelectedIndex == 0)
                mutation = new DEMutationType1((float)(Convert.ToDouble(this.differentialRate.Value) / 100.0));
            else if (this.mutationCombo.SelectedIndex == 1)
                mutation = new DEMutationType2((float)(Convert.ToDouble(this.differentialRate.Value) / 100.0));
            else if (this.mutationCombo.SelectedIndex == 2)
                mutation = new DEMutationType3((float)(Convert.ToDouble(this.differentialRate.Value) / 100.0));
            else if (this.mutationCombo.SelectedIndex == 3)
                mutation = new DEMutationType4((float)(Convert.ToDouble(this.differentialRate.Value) / 100.0));
            else if (this.mutationCombo.SelectedIndex == 4)
                mutation = new DEMutationType5((float)(Convert.ToDouble(this.differentialRate.Value) / 100.0));


            BaseLocation problem = new BaseLocation(this.city, Convert.ToInt32(this.selectBaseNumeric.Value));

            int populationSize = Convert.ToInt32(this.populationNumeric.Value), maximumIteration = Convert.ToInt32(this.maxIterationNumeric.Value),
                repeatSize = Convert.ToInt32(this.repeatNumeric.Value);

            string result = "";

            this.resultText.Text = "";


            this.totalGeneration = 0;
            this.totalTime = 0;

            DEEvolution evolution = null;
            List<int> resultList = new List<int>();

            for (int i = 0; i < repeatSize; i++)
            {

                evolution = new DEEvolution(problem, crossover, mutation, populationSize, maximumIteration);

                evolution.Start();


                resultList.Add(evolution.Population.BestSolution.Fitness);
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
        private string ResultString(DEEvolution evolution, int count)
        {


            string result = "******************************* " + count + " *******************************";
            result += "\nSelected Locations:";

            for (int i = 0; i < evolution.Population.BestSolution.Chromosome.Count; i++)
            {
                result += "\n\t" + evolution.Population.BestSolution.Chromosome[i];
            }

            result += "\n\nFitness (Persons Not In Any Base): " + evolution.Population.BestSolution.Fitness;
            result += "\nGeneration: " + evolution.GenerationCount;
            result += "\nTime: " + (evolution.EndTime - evolution.StartTime).TotalMilliseconds + " ms";
            result += "\n\n";

            return result;
        }

        //Method to fill Form
        private void FillForm()
        {
            string infoString = "";

            for (int i = 0; i < this.city.CustomerList.Count; i++)
            {
                infoString += this.city.CustomerList[i] + "\n";
            }

            this.customerText.Text = infoString;

        }

        //Method to Calculate Mean
        private double MyMean(List<int> list)
        {
            double result = 0;
            for (int i = 0; i < list.Count; i++)
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
