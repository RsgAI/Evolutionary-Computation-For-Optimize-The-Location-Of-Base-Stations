using BaseStation.Model;
using BaseStation.Problem;
using System;
using System.Collections.Generic;

namespace BaseStation.Solvent.DifferentialEvolution
{
    //Class to represent Differential Evolution
    //Differential Evolution is a continuous(numerical) optimization method
    //This Evolution will calculate position values for desired number of Base Stations
    //See https://en.wikipedia.org/wiki/Differential_evolution
    class DEEvolution
    {
        /*
        * The class contains Problem Object, Population Object, Crossover Object, Mutation Object
        * These variables will be used as parts of Evolution
        * 
        * populationSize value for hold the number of Individuals in the Population
        * generationCount value for count generations
        * maxIteration value for hold the generation in which Evolution is desired to end
        * 
        * tolerance value to hold what percentage of tolerance will be allowed for locations outside the limits
        * decreaseTolerance value to hold how often the tolerance value is to be reduced
        * 
        * startTime and endTime DateTime object to calculate the execution time of the algorithm
        * 
        */
        private BaseLocation problem;
        private DEPopulation population;
        private DECrossover crossover;
        private DEMutation mutation;
        private int populationSize, generationCount, maxIteration;
        private float tolerance;
        private int decreaseTolerance;
        private DateTime startTime, endTime;

        //Constructors
        public DEEvolution(BaseLocation problem, DECrossover crossover, DEMutation mutation, int populationSize, int maxIteration)
        {
            this.problem = problem;
            this.Crossover = crossover;
            this.GenerationCount = 0;
            this.Mutation = mutation;
            this.PopulationSize = populationSize;
            this.MaxIteration = maxIteration;
            this.tolerance = 1;
            this.decreaseTolerance = maxIteration / 5;
            this.Population = this.RandomPopulation();
        }

        public DEEvolution(BaseLocation problem, DECrossover crossover, DEMutation mutation, DEPopulation population, int eliteIndividual, int maxIteration)
        {
            this.problem = problem;
            this.Crossover = crossover;
            this.GenerationCount = 0;
            this.Mutation = mutation;
            this.Population = population;
            this.MaxIteration = maxIteration;
            this.tolerance = 1;
            this.decreaseTolerance = maxIteration / 5;
            this.PopulationSize = this.Population.List.Count;
        }
        //End of Constructors

        //Getters and Setters
        public int PopulationSize { get => populationSize; set => populationSize = value; }
        public int GenerationCount { get => generationCount; set => generationCount = value; }
        public int MaxIteration { get => maxIteration; set => maxIteration = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        internal BaseLocation Problem { get => problem; }
        internal DEPopulation Population { get => population; set => population = value; }
        internal DECrossover Crossover { get => crossover; set => crossover = value; }
        internal DEMutation Mutation { get => mutation; set => mutation = value; }
        //End of Getters and Setters

        //Method to generate Random Population
        private DEPopulation RandomPopulation()
        {
            Random rnd = new Random();
            List<DEIndividual> list = new List<DEIndividual>();
            List<Base> temp = null;

            for (int i = 0; i < this.PopulationSize; i++)
            {

                temp = new List<Base>();
                for (int j = 0; j < this.Problem.SelectedBaseSize; j++)
                {
                    temp.Add(new Base(this.Problem.City,
                        this.Problem.City.MinX + ((float)rnd.NextDouble() * (this.Problem.City.MaxX - this.Problem.City.MinX)),
                        this.Problem.City.MinY + ((float)rnd.NextDouble() * (this.Problem.City.MaxY - this.Problem.City.MinY)),
                        j));
                }

                list.Add(new DEIndividual(temp, this.Problem.CalculateFitness(temp)));

            }


            return new DEPopulation(list);

        }

        //The method that started the Evolution
        public void Start()
        {

            this.StartTime = DateTime.Now;

            while (this.Population.BestSolution.Fitness != 0 && this.GenerationCount < this.MaxIteration)
            {
                this.GenerationCount++;
                if (this.GenerationCount % this.decreaseTolerance == 0 && this.tolerance > 0)
                    this.tolerance -= 0.25f;
                this.DifferentialEvolution();
            }

            this.FeasiblePopulation();

            this.EndTime = DateTime.Now;

        }

        //Method that applies the steps of Differential Evolution
        private void DifferentialEvolution()
        {
            List<Base> chromosomeTemp = null;
            for (int i = 0; i < this.Population.List.Count; i++) {

                chromosomeTemp = this.Crossover.Aply(this.Population.List[i].Chromosome, this.Mutation.Aply(this.Population.List[i], this.Population, this.Problem), this.Problem, this.tolerance);
                this.Population.Assign(i, new DEIndividual(chromosomeTemp, this.Problem.CalculateFitness(chromosomeTemp))); 


            }


        }

        //Method that transforms infeasible solutions into feasible
        private void FeasiblePopulation()
        {

            for (int i = 0; i < this.Population.List.Count; i++)
            {
                for (int j = 0; j < this.Population.List[i].Chromosome.Count; j++)
                {
                    if (this.Population.List[i].Chromosome[j].AxisX < this.Problem.City.MinX)
                    {
                        this.Population.List[i].Chromosome[j].AxisX = this.Problem.City.MinX;
                    }
                    else if (this.Population.List[i].Chromosome[j].AxisX > this.Problem.City.MaxX)
                    {
                        this.Population.List[i].Chromosome[j].AxisX = this.Problem.City.MaxX;
                    }

                    if (this.Population.List[i].Chromosome[j].AxisY < this.Problem.City.MinY)
                    {
                        this.Population.List[i].Chromosome[j].AxisY = this.Problem.City.MinY;
                    }
                    else if (this.Population.List[i].Chromosome[j].AxisY > this.Problem.City.MaxY)
                    {
                        this.Population.List[i].Chromosome[j].AxisY = this.Problem.City.MaxY;
                    }

                }

                this.Population.List[i].Fitness = this.Problem.CalculateFitness(this.Population.List[i].Chromosome);

            }

            this.Population = new DEPopulation(this.Population.List);
        }
    }

}
