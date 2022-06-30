using System.Collections.Generic;

namespace BaseStation.Solvent.DifferentialEvolution
{
    //class to represent the Population of Individuals
    class DEPopulation
    {
        /*
        * The class contains an Individual List for hold Individuals
        * And DEIndividual Object for hold Best Solution
        */
        private List<DEIndividual> list;
        private DEIndividual bestSolution;

        //Constructors
        public DEPopulation(List<DEIndividual> list)
        {
            this.List = list;
            this.FindBest();
        }
        //End of Constructors

        //Getters and Setters
        internal List<DEIndividual> List { get => list; set => list = value; }
        internal DEIndividual BestSolution { get => bestSolution; set => bestSolution = value; }
        //End of Getters and Setters

        //Function that finds the best Individual
        private void FindBest() {
            this.BestSolution = this.List[0];
            for (int i = 1; i < this.List.Count; i++) {
                if (this.List[i].Fitness < this.BestSolution.Fitness)
                    this.BestSolution = this.List[i];
            }
        }

        //Function that assign a newly created Individual to the list if it is worthy
        public void Assign(int index, DEIndividual individual) {
            if (individual.Fitness < this.List[index].Fitness)
            {
                this.List[index] = individual;
                if (individual.Fitness < this.BestSolution.Fitness)
                    this.BestSolution = individual;
            }
        }
    }
}
