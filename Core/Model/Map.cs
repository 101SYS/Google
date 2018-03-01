using SelectFew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    class Map
    {
        // saves all rides per starting coordinate

        private List<Ride>[,] _ridesPerCoordiate;

        public Map(DataSet dataSet)
        {
            // dataSet.Rows == X
            _ridesPerCoordiate = new List<Ride>[dataSet.Rows, dataSet.Columns];
            foreach (var ride in dataSet.Rides)
            {
                var list = _ridesPerCoordiate[ride.StartPoint.X, ride.StartPoint.Y];
                if (list == null)
                {
                    list = new List<Ride>();
                    _ridesPerCoordiate[ride.StartPoint.X, ride.StartPoint.Y] = null;
                }

                list.Add(ride);
            }

        }

    }
}
