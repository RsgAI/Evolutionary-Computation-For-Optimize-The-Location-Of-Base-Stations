using BaseStation.Problem;
using System;
using System.Collections.Generic;

namespace BaseStation.Solvent.GeneticAlgorithm
{
    //Class to represent Evolution
    //See https://en.wikipedia.org/wiki/Genetic_algorithm
    class Evolution
    {
        /*
        * The class contains Problem Object, Population Object, Crossover Object, Mutation Object, Selection Object
        * These variables will be used as parts of Evolution
        * 
        * populationSize value for hold the number of Individuals in the population
        * generationCount value for count generations
        * eliteIndividual value for hold the number of elite Individuals in the population
        * maxIteration value for hold the generation in which Evolution is desired to end
        * 
        * startTime and endTime DateTime objects for calculate the execution time of the algorithm
        * 
        */
        private BaseLocation problem;
        private Population population;
        private Crossover crossover;
        private Mutation mutation;
        private Selection selection;
        private int populationSize, generationCount, eliteIndividual, maxIteration;
        private DateTime startTime, endTime;

        //Constructors
        public Evolution(BaseLocation problem, Crossover crossover, Mutation mutation, Selection selection, int populationSize, int eliteIndividual, int maxIteration)
        {
            this.problem = problem;
            this.Crossover = crossover;
            this.GenerationCount = 0;
            this.EliteIndividual = eliteIndividual;
            this.Mutation = mutation;
            this.Selection = selection;
            this.PopulationSize = populationSize;
            this.MaxIteration = maxIteration;
            this.Population = this.RandomPopulation();
        }

        public Evolution(BaseLocation problem, Crossover crossover, Mutation mutation, Selection selection, Population population, int eliteIndividual, int maxIteration)
        {
            this.problem = problem;
            this.Crossover = crossover;
            this.GenerationCount = 0;
            this.EliteIndividual = eliteIndividual;
            this.Mutation = mutation;
            this.Selection = selection;
            this.Population = population;
            this.MaxIteration = maxIteration;
            this.PopulationSize = this.Population.List.Count;
        }
        //End of Constructors

        //Getters and Setters
        public int PopulationSize { get => populationSize; set => populationSize = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int GenerationCount { get => generationCount; set => generationCount = value; }
        public int EliteIndividual { get => eliteIndividual; set => eliteIndividual = value; }
        internal BaseLocation Problem { get => problem; }
        internal Population Population { get => population; set => population = value; }
        internal Selection Selection { get => selection; set => selection = value; }
        internal Mutation Mutation { get => mutation; set => mutation = value; }
        internal Crossover Crossover { get => crossover; set => crossover = value; }
        public int MaxIteration { get => maxIteration; set => maxIteration = value; }
        //End of Getters and Setters

        //Method to generate Random Population
        private Population RandomPopulation()
        {
            Random rnd = new Random();
            List<Individual> list = new List<Individual>();
            List<int> baseIndexList = new List<int>();
            List<int> indexList;
            int index = 0;
            int[] temp;

            for (int i = 0; i < this.Problem.City.CandidateBaseList.Count; i++) {
                baseIndexList.Add(i);
            }

            for (int i = 0; i < this.PopulationSize; i++)
            {
                indexList = new List<int>(baseIndexList);
                temp = new int[this.Problem.SelectedBaseSize];

                for (int j = 0; j < this.Problem.SelectedBaseSize; j++)
                {
                    index = rnd.Next(indexList.Count);
                    temp[j] = indexList[index];
                    indexList.RemoveAt(index);
                }

                list.Add(new Individual(temp, this.Problem.CalculateFitness(temp)));

            }

            Population result = new Population(list);

            return result;

        }

        //The method that started the Evolution
        public void Start()
        {

            this.StartTime = DateTime.Now;

            while (this.Population.List[0].Fitness != 0 && GenerationCount < this.MaxIteration)
            {
                this.GenerationCount++;
                this.Population = this.GeneticAlgorithm();
            }

            this.EndTime = DateTime.Now;
        }

        //Method that applies the steps of Genetic Algorithm
        private Population GeneticAlgorithm()
        {

            Population result = new Population();
            List<Individual> individualTemp;
            List<int[]> chromosomeTemp;
            while (result.List.Count < this.PopulationSize)
            {
                individualTemp = this.Selection.Select(this.Population, 2);
                chromosomeTemp = this.Crossover.Aply(individualTemp[0].Chromosome, individualTemp[1].Chromosome);

                for (int i = 0; i < chromosomeTemp.Count; i++)
                {
                    chromosomeTemp[i] = this.Mutation.Aply(chromosomeTemp[i], this.Problem);
                    result.AddIndividual(new Individual(chromosomeTemp[i], this.Problem.CalculateFitness(chromosomeTemp[i])));
                }

            }

            for (int i = 0; i < this.EliteIndividual; i++)
            {
                result.AddIndividual(this.Population.List[0]);
                this.Population.List.RemoveAt(0);

            }

            result.List.RemoveRange(this.PopulationSize, result.List.Count - this.PopulationSize);

            return result;


        }
    }
}
