using SelectFew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectFew.mark
{
    public class Solver : ISolver
    {
        public VehicleResults Solve(DataSet data)
        {
            var ridesPerStep = data.Rides.GroupBy(r => r.EarliestStart).OrderBy(g => g.Key).Select(g => g.Select(r => r)).ToList();
            
            return null;
        }
    }
}
