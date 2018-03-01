using System.IO;

namespace SelectFew
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSetMaker = new DataSetMaker();
            var algoRunner = new AlgorithemRunner();

            var inputFile = Path.Combine(Directory.GetCurrentDirectory(), "a_example.in");

            var dataSet = dataSetMaker.CreateDataSet(File.ReadAllLines(inputFile));

            algoRunner.RunAlgorithem(dataSet);
        }
    }
}
