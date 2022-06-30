using System.Collections.Generic;

namespace BaseStation.Solvent.GeneticAlgorithm
{
    //class to represent a Population of Individuals
    class Population
    {
        /*
        * The class contains an Individual List for hold Individuals
        */
        private List<Individual> list;

        //Constructors
        public Population(List<Individual> list)
        {
            this.List = list;
            this.SortList();
        }

        public Population()
        {
            this.List = new List<Individual>();
        }
        //End of Constructors

        //Getters and Setters
        internal List<Individual> List { get => list; set => list = value; }
        //End of Getters and Setters

        //Function that sorts the list of Individuals in ascending order according to their fitness values
        public void SortList()
        {
            this.List = MergeSort(this.List, 0, this.List.Count - 1);
        }

        //Function that adds a newly added Individual to the order it should be
        public void AddIndividual(Individual individual)
        {
            bool notInsert = true;
            for (int i = 0; i < this.List.Count; i++)
            {
                if (individual.Fitness <= this.List[i].Fitness)
                {
                    this.List.Insert(i, individual);
                    notInsert = false;
                    break;
                }
            }
            if (notInsert)
                this.List.Add(individual);
        }

        //Merge Sort used by SortList
        private List<Individual> MergeSort(List<Individual> baseList, int first, int last)
        {

            List<Individual> result;

            if (first != last)
            {
                int middle = (first + last) / 2;
                List<Individual> left = MergeSort(baseList, first, middle);
                List<Individual> right = MergeSort(baseList, middle + 1, last);
                result = Merge(left, right);
            }
            else
            {
                result = new List<Individual>();
                result.Add(baseList[first]);
            }
            return result;
        }

        //Merge function used by MergeSort
        private List<Individual> Merge(List<Individual> left, List<Individual> right)
        {

            List<Individual> result = new List<Individual>();
            int rightIndex = 0, leftIndex = 0;


            while (leftIndex < left.Count && rightIndex < right.Count)
            {

                if (right[rightIndex].Fitness < left[leftIndex].Fitness)
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
