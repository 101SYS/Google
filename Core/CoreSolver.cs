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
            throw new NotImplementedException();
        }
    }
}
