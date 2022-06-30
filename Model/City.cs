using System.Collections.Generic;

namespace BaseStation.Model
{
    //Class to represent Cities
    //This class can be thought of as representing the rules of the universe in which the problem exists.
    class City
    {
        /*
        * The class contains a list of Customers and a list of candidate Base Stations,
        * minX and minY values for hold the lower limit of positions,
        * maxX and maxY values for hold the upper limit of positions,
        * 
        * The list of candidate Base Stations will be used by the Genetic Algorithm to select the desired number of stations.
        * 
        * baseRadius for hold all Base Stations coverage radius.
        * 
        */
        private List<Customer> customerList;
        private List<Base> candidateBaseList;

        private float minX, minY, maxX, maxY, baseRadius;

        //Constructors
        public City(float rangeX, float rangeY) : this(0, rangeX, 0, rangeY) { }

        public City(float minX, float maxX, float minY, float maxY)
        {
            this.MinX = minX;
            this.MaxX = maxX;

            this.MinY = minY;
            this.MaxY = maxY;
        }
        //End of Constructors

        //Getters and Setters
        public float BaseRadius { get => BaseRadius1; set => BaseRadius1 = value; }
        public float MinX { get => minX; set => minX = value; }
        public float MinY { get => minY; set => minY = value; }
        public float MaxX { get => maxX; set => maxX = value; }
        public float MaxY { get => maxY; set => maxY = value; }
        public float BaseRadius1 { get => baseRadius; set => baseRadius = value; }
        internal List<Customer> CustomerList { get => customerList; set => customerList = value; }
        internal List<Base> CandidateBaseList { get => candidateBaseList; set => candidateBaseList = value; }
        //End of Getters and Setters
    }
}
