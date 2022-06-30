using System;
using System.Collections.Generic;

namespace BaseStation.Model
{
    //Class to generate Cities
    //This class contains static methods for generating Customer and Base Station lists for the City.
    static class CityGenerator
    {

        //City generator method
        public static City Generate(float rangeX, float rangeY, int customerSize)
        {
            Random rnd = new Random();
            City result = new City(rangeX, rangeY);

            result.CustomerList = CityGenerator.RandomCustomer(customerSize, result, rnd);

            return result;

        }

        //Generates random Customers for City
        private static List<Customer> RandomCustomer(int size, City city, Random rnd) {
            List<Customer> result = new List<Customer>();

            for(int i = 0; i < size; i++)
            {
                result.Add(new Customer(city, (float)(city.MinX + (rnd.NextDouble() * (city.MaxX - city.MinX))), (float)(city.MinY + (rnd.NextDouble() * (city.MaxY - city.MinY))), i));

            }


            return result;
        }

        //Generates random Base Stations for City
        //This list will be used by the Genetic Algorithm as the candidate Base Station list.
        public static List<Base> RandomBase(int size, City city, Random rnd)
        {
            List<Base> result = new List<Base>();

            for (int i = 0; i < size; i++)
            {
                result.Add(new Base(city, (float)(city.MinX + (rnd.NextDouble() * (city.MaxX - city.MinX))), (float)(city.MinY + (rnd.NextDouble() * (city.MaxY - city.MinY))), i));

            }

            return result;
        }

    }
}
