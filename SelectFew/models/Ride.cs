using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectFew.models
{
    public class Ride
    {
        public int Index { get; private set; }
        public Point StartPoint { get; private set; }
        public Point EndPoint { get; private set; }
        public int EarliestStart { get; private set; }
        public int LatestFinish { get; private set; }
        public int Distance { get; private set; }
        public bool IsValid
        {
            get { return (LatestFinish - EarliestStart) >= Distance; } 
        }

        public Ride(int index, string line)
        {
            Index = index;
         
            var inputParams = line.Split(' ');
            StartPoint = new Point(Convert.ToInt32(inputParams[0]), Convert.ToInt32(inputParams[1]));
            EndPoint = new Point(Convert.ToInt32(inputParams[2]), Convert.ToInt32(inputParams[3]));
            EarliestStart = Convert.ToInt32(inputParams[4]);
            LatestFinish = Convert.ToInt32(inputParams[5]);
            Distance = Math.Abs(EndPoint.X - StartPoint.X) + Math.Abs(EndPoint.Y - StartPoint.Y);
        }
    }
}
