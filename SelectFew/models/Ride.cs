using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectFew.models
{
    public class Ride
    {
        public int Index { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public int EarliestStart { get; set; }
        public int LatestFinish { get; set; }

        public Ride(int index, string line)
        {
            Index = index;
         
            var inputParams = line.Split(' ');
            StartPoint = new Point(Convert.ToInt32(inputParams[0]), Convert.ToInt32(inputParams[1]));
            EndPoint = new Point(Convert.ToInt32(inputParams[2]), Convert.ToInt32(inputParams[3]));
            EarliestStart = Convert.ToInt32(inputParams[4]);
            LatestFinish = Convert.ToInt32(inputParams[5]);
        }
    }
}
