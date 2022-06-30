using BaseStation.Model;
using System;
using System.Collections.Generic;

namespace BaseStation.Problem
{
    //The class in which the variables and functions required to solve the problem are represented
    class BaseLocation
    {
        /*
        * The class contains a City object for access the rules of the problem,
        * 
        * customerSize value for hold the number of Customers in the City,
        * 
        * selectedBaseSize for hold the number of Stations to be placed in the City.
        * 
        */
        private City city;
        private int customerSize;
        private int selectedBaseSize;

        //Constructors
        public BaseLocation(City city, int selectedBaseSize) {
            this.city = city;
            this.customerSize = this.City.CustomerList.Count;
            this.selectedBaseSize = selectedBaseSize;
        }
        //End of Constructors

        //Getters and Setters
        internal City City { get => city; }
        public int CustomerSize { get => customerSize; }
        public int SelectedBaseSize { get => selectedBaseSize; }
        //End of Getters and Setters

        /*
         * The fitness function to be used for the Genetic Algorithm
         * See https://en.wikipedia.org/wiki/Fitness_function
         * 
         * Uses the ids of the Base Stations selected from the candidates as parameters
         * Returns the number of Customers that the selected Base Stations could not cover
         */
        public int CalculateFitness(int[] chromosome)
        {
            List<int> customerIndex = new List<int>();
            for (int i = 0; i < this.CustomerSize; i++) {
                customerIndex.Add(i);
            }
            double distance = 0;
            int j;
            for (int i = 0; i < chromosome.Length; i++) {
                j = 0;
                while (j < customerIndex.Count) {
                    distance = Math.Sqrt(Math.Pow((double)(this.City.CandidateBaseList[chromosome[i]].AxisX - this.City.CustomerList[customerIndex[j]].AxisX), 2)
                            + Math.Pow((double)(this.City.CandidateBaseList[chromosome[i]].AxisY - this.City.CustomerList[customerIndex[j]].AxisY), 2));
                    if (distance <= this.City.BaseRadius)
                    {
                        customerIndex.RemoveAt(j);
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return customerIndex.Count;
        }

        /*
         * The fitness function to be used for the Differential Evolution
         * See https://en.wikipedia.org/wiki/Fitness_function
         * 
         * Uses the desired number of Base Stations list as a parameter
         * Returns the number of Customers that the Base Stations could not cover
         */
        public int CalculateFitness(List<Base> chromosome)
        {
            List<int> customerIndex = new List<int>();
            for (int i = 0; i < this.CustomerSize; i++)
            {
                customerIndex.Add(i);
            }
            double distance = 0;
            int j;
            for (int i = 0; i < chromosome.Count; i++)
            {
                j = 0;
                while (j < customerIndex.Count)
                {
                    distance = Math.Sqrt(Math.Pow((double)(chromosome[i].AxisX - this.City.CustomerList[customerIndex[j]].AxisX), 2)
                            + Math.Pow((double)(chromosome[i].AxisY - this.City.CustomerList[customerIndex[j]].AxisY), 2));
                    if (distance <= this.City.BaseRadius)
                    {
                        customerIndex.RemoveAt(j);
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return customerIndex.Count;
        }
    }
}
