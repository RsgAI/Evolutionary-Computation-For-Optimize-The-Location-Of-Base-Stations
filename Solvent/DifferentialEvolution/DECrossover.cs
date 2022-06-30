using BaseStation.Model;
using BaseStation.Problem;
using System;
using System.Collections.Generic;

namespace BaseStation.Solvent.DifferentialEvolution
{
    //Abstract class to Differential Evolution Crossover operation
    //Differential Evolution is a Mutation based algorithm
    //In Differential Evolution algorithms the Crossover operator allows the construction of a new trial element starting from the current and mutant elements
    //See https://www.sciencedirect.com/science/article/abs/pii/S1568494609000325
    abstract class DECrossover
    {
        /*
        * The class contains a random object to be used by all Crossover classes
        * rate value for hold whether a gene will mutate
        */
        private Random rnd;
        private double rate;

        //Constructors
        public DECrossover(double rate)
        {
            this.rate = rate;
            this.Rnd = new Random();
        }
        //End of Constructors

        //Getters and Setters
        public Random Rnd { get => rnd; set => rnd = value; }
        public double Rate { get => rate;}
        //End of Getters and Setters

        //Abstract method for Differential Evolution Crossover
        public abstract List<Base> Aply(List<Base> current, List<Base> mutant, BaseLocation problem, float tolerance);

    }

    //Class to Type1 Crossover
    //Only one type of Crossover will be used
    //This method replaces the genes to be mutated with the genes of the mutant Individual created
    class DECrossoverType1 : DECrossover
    {
        //Constructors
        public DECrossoverType1(double rate) : base(rate){ }
        //End of Constructors

        /*
        * Apply function to Type1 Crossover
        * Takes two Base List, BaseLocation Object and tolerance value as parameters
        * Returns new Base List
        */
        public override List<Base> Aply(List<Base> current, List<Base> mutant, BaseLocation problem, float tolerance)
        {
            int J = Rnd.Next(mutant.Count);
            for (int i = 0; i < mutant.Count; i++) {
                if (Rnd.NextDouble() < this.Rate || i == J) {

                    if (mutant[i].AxisX < problem.City.MinX)
                        mutant[i].AxisX = mutant[i].AxisX * tolerance + problem.City.MinX * (1 - tolerance);
                    else if (mutant[i].AxisX > problem.City.MaxX)
                        mutant[i].AxisX = mutant[i].AxisX * tolerance + problem.City.MaxX * (1 - tolerance);

                    if (mutant[i].AxisY < problem.City.MinY)
                        mutant[i].AxisY = mutant[i].AxisY * tolerance + problem.City.MinY * (1 - tolerance);
                    else if (mutant[i].AxisY > problem.City.MaxY)
                        mutant[i].AxisY = mutant[i].AxisY * tolerance + problem.City.MaxY * (1 - tolerance);

                } else
                {
                    if (current[i].AxisX < problem.City.MinX)
                        mutant[i].AxisX = current[i].AxisX * tolerance + problem.City.MinX * (1 - tolerance);
                    else if (current[i].AxisX > problem.City.MaxX)
                        mutant[i].AxisX = current[i].AxisX * tolerance + problem.City.MaxX * (1 - tolerance);
                    else
                        mutant[i].AxisX = current[i].AxisX;

                    if (current[i].AxisY < problem.City.MinY)
                        mutant[i].AxisY = current[i].AxisY * tolerance + problem.City.MinY * (1 - tolerance);
                    else if (current[i].AxisY > problem.City.MaxY)
                        mutant[i].AxisY = current[i].AxisY * tolerance + problem.City.MaxY * (1 - tolerance);
                    else
                        mutant[i].AxisY = current[i].AxisY;
                }
            }
            return mutant;
        }
    }
}
