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
        public DataSet CreateDataSet(string[] lines,string filePath)
        {
            var dataSet = new DataSet(lines[0], filePath);
            dataSet.CreateRides(lines);
            return dataSet;
        }
    }
}
