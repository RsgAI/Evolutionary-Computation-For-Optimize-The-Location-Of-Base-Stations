using BaseStation.Problem;
using System;
using System.Collections.Generic;

namespace BaseStation.Solvent.GeneticAlgorithm
{
    //Abstract class to Mutation operation
    //See https://en.wikipedia.org/wiki/Mutation_(genetic_algorithm)
    abstract class Mutation
    {
        /*
        * The class contains a random object to be used by all Mutation classes
        * generalMutationRate value for hold the probability that an Individual will mutate
        * individualMutationRate value, for hold what rate an Individual who will mutate will mutate.
        */
        private double generalMutationRate, individualMutationRate;
        private Random rnd;

        //Constructors
        public Mutation(double generalMutationRate, double individualMutationRate)
        {
            this.GeneralMutationRate = generalMutationRate;
            this.IndividualMutationRate = individualMutationRate;
            this.Rnd = new Random();
        }
        //End of Constructors

        //Getters and Setters
        public double GeneralMutationRate { get => generalMutationRate; set => generalMutationRate = value; }
        public double IndividualMutationRate { get => individualMutationRate; set => individualMutationRate = value; }
        public Random Rnd { get => rnd; set => rnd = value; }
        //End of Getters and Setters

        //Abstract method for Mutation
        public abstract int[] Aply(int[] source, BaseLocation problem);
    }

    //class to Classic Mutation
    /*
    * This Mutation calculates the number of genes that need to be changed over the individualMutationRate
    * And randomly changes that number of genes of the Individual
    */
    class ClassicMutation : Mutation
    {
        //Constructors
        public ClassicMutation(double generalMutationRate, double individualMutationRate) : base(generalMutationRate, individualMutationRate) { }
        //End of Constructors

        /*
         * Apply function to Classic Mutation
         * Takes the chromosome and the Problem as parameters
         * Returns the chromosome itself or the new chromosome formed after it mutated
         */
        public override int[] Aply(int[] source, BaseLocation problem)
        {
            int changedElement = 0;
            int index1 = 0, index2 = 0, temp = 0;
            int elementSize;

            List<int> notUsedIndex = new List<int>();

            if (this.Rnd.NextDouble() < this.GeneralMutationRate)
            {
                for (int i = 0; i < problem.City.CandidateBaseList.Count; i++)
                {
                    notUsedIndex.Add(i);
                }

                for (int i = 0; i < source.Length; i++)
                {
                    notUsedIndex.Remove(source[i]);
                }

                elementSize = (int)Math.Ceiling(problem.SelectedBaseSize * this.IndividualMutationRate);
                while (changedElement < elementSize)
                {
                    index1 = this.Rnd.Next(source.Length);
                    index2 = this.Rnd.Next(notUsedIndex.Count);

                    temp = source[index1];
                    source[index1] = notUsedIndex[index2];
                    notUsedIndex[index2] = temp;
                    changedElement++;
                }

            }

            return source;
        }
    }


    //class to Step Mutation
    //Step Mutation name is representative only

    /*
     * This Mutation, going around all the genes of the chromosome to be mutated one by one
     * And changing each one with a probability of individualMutationRate
     */
    class StepMutation : Mutation
    {
        //Constructors
        public StepMutation(double generalMutationRate, double individualMutationRate) : base(generalMutationRate, individualMutationRate) { }
        //End of Constructors

        /*
         * Apply function to Step Mutation
         * Takes the chromosome and the problem as parameters
         * Returns the chromosome itself or the new chromosome formed after it mutated
         */
        public override int[] Aply(int[] source, BaseLocation problem)
        {

            int temp = 0, index = 0;
            List<int> notUsedIndex = new List<int>();
            

            if (this.Rnd.NextDouble() < this.GeneralMutationRate)
            {
                for (int i = 0; i < problem.City.CandidateBaseList.Count; i++)
                {
                    notUsedIndex.Add(i);
                }

                for (int i = 0; i < source.Length; i++)
                {
                    notUsedIndex.Remove(source[i]);
                }

                for (int i = 0; i < source.Length; i++)
                {
                    if (this.Rnd.NextDouble() < this.IndividualMutationRate)
                    {
                        index = Rnd.Next(notUsedIndex.Count);
                        temp = source[i];
                        source[i] = notUsedIndex[index];
                        notUsedIndex[index] = temp;
                    }
                }

            }

            return source;
        }
    }
}
