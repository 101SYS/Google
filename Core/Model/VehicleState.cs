using SelectFew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    class VehicleState
    {
        public List<Ride> RideHistory { get; set; } = new List<Ride>();
        public Point TimeLocation { get; set; }
        public int FirstRelevantTime { get; set; }

        public List<List<Point>> PossibleMovesUpToCurrentTime { get; set; }

    }
}
