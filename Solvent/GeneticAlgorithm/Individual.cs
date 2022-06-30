namespace BaseStation.Solvent.GeneticAlgorithm
{
    //Class to represent Individuals used in the genetic algorithm
    class Individual
    {
        /*
        * The class contains an integer array, named chromosome
        * chromosome contains the specified number of candidate Base Station ids.
        * fitness value for indicating the quality of the Individual
        */
        private int[] chromosome;
        private int fitness;

        //Constructors
        public Individual(int[] chromosome, int fitness) {
            this.chromosome = chromosome;
            this.fitness = fitness;
        }
        //End of Constructors

        //Getters and Setters
        public int[] Chromosome { get => chromosome;}
        public int Fitness { get => fitness;}
        //End of Getters and Setters
    }
}
