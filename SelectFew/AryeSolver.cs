using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectFew.models;

namespace SelectFew
{
   public class AryeSolver: ISolver
    {
        public VehicleResults Solve(DataSet data)
        {
            var orderedRides = data.Rides.OrderBy(x => x.Steps).ToList();

            if (orderedRides.Count <= data.Vehicles)
            {

            }
            else
            {

            }

            foreach (var ride in orderedRides)
            {
               
            }
        }
    }
}
