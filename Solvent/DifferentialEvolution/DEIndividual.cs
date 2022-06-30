using BaseStation.Model;
using System.Collections.Generic;

namespace BaseStation.Solvent.DifferentialEvolution
{
    //Class to represent Individuals used in the Differential Evolution
    class DEIndividual
    {
        /*
        * The class contains a Base List, named chromosome
        * chromosome contains the specified number of Base Stations.
        * fitness value for indicating the quality of the Individual
        */
        private List<Base> chromosome;
        private int fitness;

        //Constructors
        public DEIndividual(List<Base> chromosome, int fitness)
        {
            this.chromosome = chromosome;
            this.fitness = fitness;
        }
        //End of Constructors

        //Getters and Setters
        public int Fitness { get => fitness; set => fitness = value; }
        internal List<Base> Chromosome { get => chromosome; set => chromosome = value; }
        //End of Getters and Setters
    }
}
