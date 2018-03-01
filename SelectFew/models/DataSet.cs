using System;
using System.Collections.Generic;

namespace SelectFew.models
{
    public class DataSet
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Vehicles { get; set; }
        public int NumRides { get; set; }
        public int PerRideBonus { get; set; }
        public int Steps { get; set; }
        public VehicleResults Result { get; set; }
        public List<Ride> Rides { get; set; }

        public DataSet(string inputParamsLine)
        {
            var inputParams = inputParamsLine.Split(' ');
            Rows = Convert.ToInt32(inputParams[0]);
            Columns = Convert.ToInt32(inputParams[1]);
            Vehicles = Convert.ToInt32(inputParams[2]);
            NumRides = Convert.ToInt32(inputParams[3]);
            PerRideBonus = Convert.ToInt32(inputParams[4]);
            Steps = Convert.ToInt32(inputParams[5]);
            Rides = new List<Ride>();
        }

        public void CreateRides(string[] lines)
        {
            for (var i = 1; i <= NumRides; i++)
            {
                Rides.Add(new Ride(i - 1, lines[i]));
            }
        }
    }
}
