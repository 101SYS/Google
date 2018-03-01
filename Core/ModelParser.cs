using System;
using Core.Model;
using SelectFew.models;

namespace Core
{
    internal class ModelParser
    {
        public ModelParser()
        {
        }

        internal DataState Parse(DataSet data)
        {
            DataState state = new DataState();
            state.RidesMap = new Map(data);
            state.CurrentTime = 0;
            state.MaxTime = data.Steps;
            state.VehicleTime = new VehicleTimeState(data);
            state.Vehicles = new VehicleState[data.Vehicles];
            for (int i = 0; i < state.Vehicles.Length; i++)
            {
                state.Vehicles[i] = new VehicleState()
                {
                    FirstRelevantTime = 0,
                    TimeLocation = new Point(0, 0),
                    RideHistory = new System.Collections.Generic.List<Ride>(),
                    PossibleMovesUpToCurrentTime = new System.Collections.Generic.List<System.Collections.Generic.List<Point>>(),
                };
            }
            
            return state;
        }
    }
}