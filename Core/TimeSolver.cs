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
            var allRides = new HashSet<int>(vehicleToPotentials.Values.SelectMany(p => p.Select(x => x.Index)));

            foreach (var vehiclePotentialPair in vehicleToPotentials)
            {
                foreach (var item in vehiclePotentialPair.Value.Where(r => allRides.Contains(r.Index)))
                {
                    if(ShouldAssignRide(state, vehiclePotentialPair.Key, item))
                    {
                        allRides.Remove(item.Index);
                        AssignRide(state, vehiclePotentialPair.Key, item);
                    }
                }
            }
        }

        private void AssignRide(DataState state, int vehicleIndex, Ride item)
        {
            var vehicle = state.Vehicles[vehicleIndex];
            vehicle.RideHistory.Add(item);

            var currentVehicleTime = vehicle.FirstRelevantTime;
            AssignNextTime(vehicle, currentVehicleTime, vehicle.TimeLocation, item);
            // todo: update TimeLocation  and PotentialPoints


        }

        private void AssignNextTime(VehicleState vehicle, int currentVehicleTime, Point timeLocation, Ride item)
        {
            int dTr = GetDistance(timeLocation, item.StartPoint);
            int waitTime = Math.Max(currentVehicleTime + dTr, item.EarliestStart) - currentVehicleTime;
            int dTt = GetDistance(item.StartPoint, item.EndPoint);
            // get distance
            vehicle.FirstRelevantTime = currentVehicleTime + dTr + waitTime + dTt;

            vehicle.TimeLocation = item.EndPoint;
            vehicle.PossibleMovesUpToCurrentTime.Clear();
        }

        private int GetDistance(Point a, Point b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
        }

        private bool ShouldAssignRide(DataState state, int key, Ride item)
        {
            // todo throw new NotImplementedException();
            return true;
        }

        private List<Ride> GetPotentialRides(DataState state, int vechileId)
        {
            var vehicle = state.Vehicles[vechileId];
            var rides = new List<Ride>();
            foreach (var point in vehicle.PossibleMovesUpToCurrentTime.SelectMany(l => l))
            {
                var ridesInPoint = state.RidesMap.GetRides(point.X, point.Y);
                rides.AddRange(ridesInPoint);
            }

            return rides;
        }

        private IEnumerable<int> GetRelevantVehicles(DataState state)
        {
            return state.VehicleTime.GetVehiclesUpToTime(state.CurrentTime);
        }
    }
}
