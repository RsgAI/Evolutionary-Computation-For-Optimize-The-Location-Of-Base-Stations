using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseStation.Solvent.GeneticAlgorithm
{
    //Abstract class to Crossover operation
    //See https://en.wikipedia.org/wiki/Crossover_(genetic_algorithm)
    abstract class Crossover
    {
        /*
        * The class contains a random object to be used by all Crossover classes
        */
        private Random rnd;

        //Constructors
        public Crossover()
        {
            this.Rnd = new Random();
        }
        //End of Constructors

        //Getters and Setters
        public Random Rnd { get => rnd; set => rnd = value; }
        //End of Getters and Setters

        //Abstract method for Crossover
        public abstract List<int[]> Aply(int[] parent1, int[] parent2);

    }

    //Class to Classic Crossover
    /*
    * This Crossover performs the Crossover as a Permutation Crossover over a single randomly selected index
    * It produces two new Individuals.
    */
    class ClassicCrossover : Crossover
    {
        //Constructors
        public ClassicCrossover() : base() { }
        //End of Constructors

        /*
         * Apply function to Classic Crossover
         * Takes two Chromosome as parameters
         * Returns two new Chromosomes
         */
        public override List<int[]> Aply(int[] parent1, int[] parent2)
        {

            int index = this.Rnd.Next(parent1.Length - 1) + 1;
            int temp1, temp2;
            List<int[]> result = new List<int[]>();

            int[] child1 = new int[parent1.Length];
            int[] child2 = new int[parent2.Length];

            for (int i = 0; i < child1.Length; i++) {
                child1[i] = -1;
                child2[i] = -1;
            }

            result.Add(child1);
            result.Add(child2);

            for (int i = 0; i < index; i++)
            {
                result[0][i] = parent1[i];
                result[1][i] = parent2[i];
            }

            temp1 = index;
            temp2 = index;
            for (int i = index; i < parent1.Length; i++) {

                while (result[0].Contains(parent2[temp1 % parent2.Length]))
                    temp1++;

                result[0][i] = parent2[temp1 % parent2.Length];
                temp1++;


                while (result[1].Contains(parent1[temp2 % parent1.Length]))
                    temp2++;

                result[1][i] = parent1[temp2 % parent1.Length];
                temp2++;
            }

            return result;

        }
    }

    //class to Order1 Crossover
    /*
    * This Crossover performs the Crossover as a Permutation Crossover over two randomly selected index
    * It produces two new Individuals.
    */
    class Order1Crossover : Crossover
    {
        //Constructors
        public Order1Crossover() : base() { }
        //End of Constructors

        /*
         * Apply function to Order1 Crossover
         * Takes two Chromosome as parameters
         * Returns two new Chromosomes
         */
        public override List<int[]> Aply(int[] parent1, int[] parent2)
        {

            int index1 = this.Rnd.Next(parent1.Length);
            int index2 = this.Rnd.Next(parent1.Length - index1) + index1;
            int temp1, temp2;
            List<int[]> result = new List<int[]>();

            int[] child1 = new int[parent1.Length];
            int[] child2 = new int[parent2.Length];

            for (int i = 0; i < child1.Length; i++)
            {
                child1[i] = -1;
                child2[i] = -1;
            }

            result.Add(child1);
            result.Add(child2);

            for (int i = index1; i <= index2; i++)
            {
                result[0][i] = parent1[i];
                result[1][i] = parent2[i];
            }

            temp1 = index2 + 1;
            temp2 = index2 + 1;
            for (int i = index2 + 1; i < parent1.Length; i++)
            {

                while (result[0].Contains(parent2[temp1 % parent2.Length]))
                    temp1++;

                result[0][i] = parent2[temp1 % parent2.Length];
                temp1++;

                while (result[1].Contains(parent1[temp2 % parent1.Length]))
                    temp2++;

                result[1][i] = parent1[temp2 % parent1.Length];
                temp2++;
            }

            for (int i = 0; i < index1; i++)
            {
                while (result[0].Contains(parent2[temp1 % parent2.Length]))
                    temp1++;

                result[0][i] = parent2[temp1 % parent2.Length];
                temp1++;

                while (result[1].Contains(parent1[temp2 % parent1.Length]))
                    temp2++;

                result[1][i] = parent1[temp2 % parent1.Length];
                temp2++;
            }

            return result;

        }
    }
}
