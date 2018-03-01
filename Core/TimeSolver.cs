using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using SelectFew.models;

namespace Core
{
    class TimeSolver
    {
        internal void Solve(DataState state)
        {
            for (state.CurrentTime = 0; state.CurrentTime <= state.MaxTime; state.CurrentTime++)
            {
                IEnumerable<int> relevantVehicles = GetRelevantVehicles(state);

                Dictionary<int, List<Ride>> vehicleToPotentials = new Dictionary<int, List<Ride>>();
                foreach (var vechileId in relevantVehicles)
                {
                    vehicleToPotentials.Add(vechileId, GetPotentialRides(state, vechileId));
                }

                ApplyRideToVehicles(state, vehicleToPotentials);
            }
            
            // todo: need to create all "RidesHistory"
        }

        private void ApplyRideToVehicles(DataState state, Dictionary<int, List<Ride>> vehicleToPotentials)
        {
            throw new NotImplementedException();
        }

        private List<Ride> GetPotentialRides(DataState state, int vechileId)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<int> GetRelevantVehicles(DataState state)
        {
            return state.VehicleTime.GetVehiclesUpToTime(state.CurrentTime);
        }
    }
}
