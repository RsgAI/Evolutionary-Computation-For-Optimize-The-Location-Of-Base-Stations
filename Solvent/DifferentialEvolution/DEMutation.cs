using BaseStation.Model;
using BaseStation.Problem;
using System;
using System.Collections.Generic;

namespace BaseStation.Solvent.DifferentialEvolution
{
    //Abstract class to  Differential Evolution Mutation operation
    //See https://arxiv.org/ftp/arxiv/papers/1510/1510.02516.pdf : page 3-4
    abstract class DEMutation
    {
        /*
        * The class contains a random object to be used by all Mutation classes
        * differential value for hold the rate of movement
        */
        private Random rnd;
        private float differential;

        //Constructors
        public DEMutation(float differential)
        {
            this.differential = differential;
            this.Rnd = new Random();
        }
        //End of Constructors

        //Getters and Setters
        public Random Rnd { get => rnd; set => rnd = value; }
        public float Differential { get => differential;}
        //End of Getters and Setters

        //Abstract method for Differential Evolution Mutation
        public abstract List<Base> Aply(DEIndividual current, DEPopulation population, BaseLocation problem);

        //Method for random selection of individuals
        public List<List<Base>> select(DEPopulation population, int selectSize) {

            List<List<Base>> result = new List<List<Base>>();
            List<int> indexList = new List<int>();

            for (int i = 0; i < population.List.Count; i++)
            {
                indexList.Add(i);
            }

            int randomIndex = 0;

            for (int i = 0; i < selectSize; i++) {

                randomIndex = rnd.Next(indexList.Count);

                result.Add(population.List[indexList[randomIndex]].Chromosome);
                indexList.RemoveAt(randomIndex);
            }

            return result;
        }
    }


    // DE/rand/1
    class DEMutationType1 : DEMutation
    {
        //Constructors
        public DEMutationType1(float differential) : base(differential) { }
        //End of Constructors

        /*
        * Apply function to DE/rand/1 Mutation
        * Takes a DEIndividual Object, DEPopulation Object and BaseLocation Object as parameters
        * Returns new Base List as Mutant Individual
        */
        public override List<Base> Aply(DEIndividual current, DEPopulation population, BaseLocation problem)
        {
            List<Base> result = new List<Base>();

            List<List<Base>> selected = this.select(population, 3);

            for(int i = 0; i < problem.SelectedBaseSize; i++)
            {
                result.Add(new Base(
                    problem.City,
                    selected[0][i].AxisX + this.Differential * (selected[1][i].AxisX - selected[2][i].AxisX),
                    selected[0][i].AxisY + this.Differential * (selected[1][i].AxisY - selected[2][i].AxisY),
                    i));

            }


            return result;
        }
    }

    // DE/rand/2
    class DEMutationType2 : DEMutation
    {
        //Constructors
        public DEMutationType2(float differential) : base(differential) { }
        //End of Constructors

        /*
        * Apply function to DE/rand/2 Mutation
        * Takes a DEIndividual Object, DEPopulation Object and BaseLocation Object as parameters
        * Returns new Base List as Mutant Individual
        */
        public override List<Base> Aply(DEIndividual current, DEPopulation population, BaseLocation problem)
        {
            List<Base> result = new List<Base>();

            List<List<Base>> selected = this.select(population, 5);

            for (int i = 0; i < problem.SelectedBaseSize; i++)
            {
                result.Add(new Base(
                    problem.City,
                    selected[0][i].AxisX + this.Differential * (selected[1][i].AxisX - selected[2][i].AxisX + selected[3][i].AxisX - selected[4][i].AxisX),
                    selected[0][i].AxisY + this.Differential * (selected[1][i].AxisY - selected[2][i].AxisY + selected[3][i].AxisY - selected[4][i].AxisY),
                    i));

            }


            return result;
        }
    }

    // DE/best/1
    class DEMutationType3 : DEMutation
    {
        //Constructors
        public DEMutationType3(float differential) : base(differential) { }
        //End of Constructors

        /*
        * Apply function to DE/best/1 Mutation
        * Takes a DEIndividual Object, DEPopulation Object and BaseLocation Object as parameters
        * Returns new Base List as Mutant Individual
        */
        public override List<Base> Aply(DEIndividual current, DEPopulation population, BaseLocation problem)
        {
            List<Base> result = new List<Base>();

            List<List<Base>> selected = this.select(population, 2);

            for (int i = 0; i < problem.SelectedBaseSize; i++)
            {
                result.Add(new Base(
                    problem.City,
                    population.BestSolution.Chromosome[i].AxisX + this.Differential * (selected[0][i].AxisX - selected[1][i].AxisX),
                    population.BestSolution.Chromosome[i].AxisY + this.Differential * (selected[0][i].AxisY - selected[1][i].AxisY),
                    i));

            }


            return result;
        }
    }

    // DE/best/2
    class DEMutationType4 : DEMutation
    {
        //Constructors
        public DEMutationType4(float differential) : base(differential) { }
        //End of Constructors

        /*
        * Apply function to DE/best/2 Mutation
        * Takes a DEIndividual Object, DEPopulation Object and BaseLocation Object as parameters
        * Returns new Base List as Mutant Individual
        */
        public override List<Base> Aply(DEIndividual current, DEPopulation population, BaseLocation problem)
        {
            List<Base> result = new List<Base>();

            List<List<Base>> selected = this.select(population, 4);

            for (int i = 0; i < problem.SelectedBaseSize; i++)
            {
                result.Add(new Base(
                    problem.City,
                    population.BestSolution.Chromosome[i].AxisX + this.Differential * (selected[0][i].AxisX - selected[1][i].AxisX + selected[2][i].AxisX - selected[3][i].AxisX),
                    population.BestSolution.Chromosome[i].AxisY + this.Differential * (selected[0][i].AxisY - selected[1][i].AxisY + selected[2][i].AxisY - selected[3][i].AxisY),
                    i));

            }


            return result;
        }
    }

    // DE/current-to-best/1
    class DEMutationType5 : DEMutation
    {
        //Constructors
        public DEMutationType5(float differential) : base(differential) { }
        //End of Constructors

        /*
        * Apply function to DE/current-to-best/1 Mutation
        * Takes a DEIndividual Object, DEPopulation Object and BaseLocation Object as parameters
        * Returns new Base List as Mutant Individual
        */
        public override List<Base> Aply(DEIndividual current, DEPopulation population, BaseLocation problem)
        {
            List<Base> result = new List<Base>();

            List<List<Base>> selected = this.select(population, 2);

            for (int i = 0; i < problem.SelectedBaseSize; i++)
            {
                result.Add(new Base(
                    problem.City,
                    current.Chromosome[i].AxisX + this.Differential * (population.BestSolution.Chromosome[i].AxisX - current.Chromosome[i].AxisX + selected[0][i].AxisX - selected[1][i].AxisX),
                    current.Chromosome[i].AxisY + this.Differential * (population.BestSolution.Chromosome[i].AxisY - current.Chromosome[i].AxisY + selected[0][i].AxisY - selected[1][i].AxisY),
                    i));

            }


            return result;
        }
    }
}
