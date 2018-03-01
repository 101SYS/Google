using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectFew.models;

namespace SelectFew
{
   public class DataSetMaker
    {
        public DataSet CreateDataSet(string[] lines)
        {
            var dataSet = new DataSet(lines[0]);
            dataSet.CreateRides(lines);
            return dataSet;
        }
    }
}
