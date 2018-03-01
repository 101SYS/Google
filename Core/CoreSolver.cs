using Core.Model;
using SelectFew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class CoreSolver : ISolver
    {
        public List<VehicleResults> Solve(DataSet data)
        {
            ModelParser parser = new ModelParser();
            DataState state = parser.Parse(data);

            TimeSolver solver = new TimeSolver();
            solver.Solve(state);

            return state.Vehicles.Select(vehicle => new VehicleResults()
            {
                RidesIndexs = vehicle.RideHistory.Select(r => r.Index).ToList(),
            }).ToList();
        }
    }
}
