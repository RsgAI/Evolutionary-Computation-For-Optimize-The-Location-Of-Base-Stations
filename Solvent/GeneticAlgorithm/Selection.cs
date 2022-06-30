using System;
using System.Collections.Generic;

namespace BaseStation.Solvent.GeneticAlgorithm
{
    //Abstract class to Selection operation
    //See https://en.wikipedia.org/wiki/Selection_(genetic_algorithm)
    abstract class Selection
    {
        /*
        * The class contains a random object to be used by all Selection classes
        */
        private Random rnd;

        //Constructors
        public Selection()
        {
            this.Rnd = new Random();
        }
        //End of Constructors

        //Getters and Setters
        public Random Rnd { get => rnd; set => rnd = value; }
        //End of Getters and Setters

        //Abstract method for selection
        public abstract List<Individual> Select(Population population, int selectSize);
    }

    //class to Rulet Wheel Selection
    //See https://en.wikipedia.org/wiki/Fitness_proportionate_selection
    class RouletteWheel : Selection
    {

        //Constructors
        public RouletteWheel() : base() { }
        //End of Constructors

        /*
         * The Select function to Roulette Wheel selection
         * Takes a Population object and a selectSize value as parameters
         * Selects and returns selectSize Individuals from the Population object
         */
        public override List<Individual> Select(Population population, int selectSize)
        {
            List<Individual> result = new List<Individual>();
            List<float> possibilities = new List<float>();
            int maxFitness = 0, minFitness = population.List[0].Fitness;

            for (int i = 0; i < population.List.Count; i++)
            {

                if (population.List[i].Fitness > maxFitness)
                    maxFitness = population.List[i].Fitness;

                if (population.List[i].Fitness < minFitness)
                    minFitness = population.List[i].Fitness;
            }
            
            maxFitness++;

            float possibility = 0;
            for (int i = 0; i < population.List.Count; i++)
            {
                possibility += (float)(maxFitness - population.List[i].Fitness) / (maxFitness - minFitness);
                possibilities.Add(possibility);
            }

            double random;

            while (result.Count < selectSize)
            {

                random = this.Rnd.NextDouble() * possibility;

                for (int j = 0; j < possibilities.Count; j++)
                {

                    if (random < possibilities[j])
                    {
                        if (!result.Contains(population.List[j]))
                        {
                            result.Add(population.List[j]);
                        }
                        break;
                    }

                }

            }

            return result;
        }
    }

    //class to Tournament Selection
    //See https://en.wikipedia.org/wiki/Tournament_selection
    class Tournament : Selection
    {
        /*
        * The class contains tournamentSize value 
        * for hold the number of Individuals who will participate in the tournament
        */
        private int tournamentSize;

        //Constructors
        public Tournament(int tournamentSize) : base()
        {

            this.TournamentSize = tournamentSize;

        }
        //End of Constructors

        //Getters and Setters
        public int TournamentSize { get => tournamentSize; set => tournamentSize = value; }
        //End of Getters and Setters

        /*
         * The Select function to Tournament selection
         * Takes a Population object and a selectSize value as parameters
         * Selects and returns selectSize Individuals from the Population object
         */
        public override List<Individual> Select(Population population, int selectSize)
        {
            List<int> populationIndex = new List<int>();
            int index = 0;
            List<Individual> tournamentList = new List<Individual>();
            List<Individual> result = new List<Individual>();

            for (int i = 0; i < population.List.Count; i++)
            {
                populationIndex.Add(i);
            }

            while (tournamentList.Count < this.TournamentSize)
            {
                index = this.Rnd.Next(populationIndex.Count);
                tournamentList.Add(population.List[populationIndex[index]]);
                populationIndex.RemoveAt(index);
            }


            return new Population(tournamentList).List.GetRange(0, selectSize);
        }
    }
}
