using System;
using System.Collections.Generic;
using System.IO;
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

        public void ShowOutPut(List<VehicleResults> vehicles, string fileName)
        {
            var sb = new StringBuilder();

            foreach (var vehicleResultse in vehicles)
            {
                sb.AppendLine(MakeLine(vehicleResultse));
            }

            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "Output_" + fileName), sb.ToString());

        }

        private string MakeLine(VehicleResults res)
        {
            var sb = new StringBuilder();
            sb.Append(res.RidesIndexs.Count + " ");
            foreach (var i in res.RidesIndexs)
            {
                sb.Append(i + " ");
            }
            return sb.ToString();
        }

    }
}
