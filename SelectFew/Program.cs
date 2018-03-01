using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SelectFew.models;

namespace SelectFew
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSetMaker = new DataSetMaker();
            var algoRunner = new AlgorithemRunner();
            var tasks = new List<Task>();
            var inputFiles = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "InputData"));
            var dataSets = new List<DataSet>();
            foreach (var filePath in inputFiles)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    var inputFile = Path.Combine(Directory.GetCurrentDirectory(), filePath);
                    var data = dataSetMaker.CreateDataSet(File.ReadAllLines(inputFile));
                    dataSets.Add(data);
                    algoRunner.RunAlgorithem(data);
                }));
            }

            Task.WaitAll(tasks.ToArray());

            foreach (DataSet dataSet in dataSets)
            {
                algoRunner.ShowOutPut(dataSet.Result);
            }
        }


    }
}
