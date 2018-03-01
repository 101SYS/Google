using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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
            foreach (var filePath in inputFiles)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    var inputFile = Path.Combine(Directory.GetCurrentDirectory(), filePath);
                    algoRunner.RunAlgorithem(dataSetMaker.CreateDataSet(File.ReadAllLines(inputFile)));
                }));

            }

            Task.WaitAll(tasks.ToArray());

        }


    }
}
