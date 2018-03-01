using SelectFew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    class VehicleTimeState
    {
        private HashSet<int>[] _vehiclesInTime;

        public VehicleTimeState(DataSet dataSet)
        {
            _vehiclesInTime = new HashSet<int>[dataSet.Steps + 1];
            for (int i = 0; i < _vehiclesInTime.Length; i++)
            {
                _vehiclesInTime[i] = new HashSet<int>();
            }

            foreach (var vehicleId in Enumerable.Range(0, dataSet.Vehicles))
            {
                _vehiclesInTime[0].Add(vehicleId);
            }
        }

    }
}
