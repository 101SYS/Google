using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectFew.models;

namespace SelectFew
{
    public class AlgorithemRunner
    {
        public void RunAlgorithem(DataSet dataSet)
        {

        }

        public void ShowOutPut(VehicleResults vehicle)
        {
            var sb = new StringBuilder();
          
            Console.Write(vehicle.RidesIndexs.Count + " ");
            vehicle.RidesIndexs.ForEach(index => Console.Write(index + " "));
        }

    }
}
