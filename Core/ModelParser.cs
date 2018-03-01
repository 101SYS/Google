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

            return state;
        }
    }
}