namespace BaseStation.Model
{
    //Class to represent Base Stations
    class Base
    {
        /*
        * The class contains an id value for the station's identity,
        * x and y values for hold the station's location,
        * and a City object for hold the city to which the station belongs.
        */
        private City city;
        private float axisX, axisY;
        private int id;

        //Constructors
        public Base(City city, float axisX, float axisY, int id)
        {
            this.City = city;
            this.AxisX = axisX;
            this.AxisY = axisY;
            this.Id = id;
        }
        //End of Constructors

        //Getters and Setters
        public float AxisX { get => axisX; set => axisX = value; }
        public float AxisY { get => axisY; set => axisY = value; }
        public int Id { get => id; set => id = value; }
        internal City City { get => city; set => city = value; }
        //End of Getters and Setters

        //ToString Method for print
        public override string ToString()
        {
            return "Base Location" + this.Id + " (" + this.AxisX + ", " + this.AxisY + ")";
        }
    }
}
