using DataGenerators;
using Algorithms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Tests
{
    public class TestProgram
    {

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<LinearSearchBenchMarker>();
        }
    }

    public class LinearSearchBenchMarker
    {
        private readonly ILinearDataStructureSearch<int> searcher;
        private IEnumerable<int> iData, rData;

        [Params(1 , 500, 1000)]
        public int key;

        public LinearSearchBenchMarker()
        {
            searcher = new LinearDataStructureSearch<int>();
            iData = NumberGenerator.SortedArray(1000);
            rData = NumberGenerator.SortedArray(1000);
        }

        [Benchmark]
        public void Ite() => searcher.IterativeSearch(iData, key);

        [Benchmark]
        public void Rec() => searcher.RecursiveSearch(rData, key, 0);
    }
}


















//static System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
//var alg = new LinearDataStructureSearch<int>();
//string r = "";

//for(int i = 10; i <= 1e4; i *= 10)
//{
//    var sortedArray = NumberGenerator.SortedArray(i);
//    int numberToFind = sortedArray.Count() - 1;
//    r += Do(alg, sortedArray, numberToFind) + "\n";
//}

//Console.WriteLine(r);
//static void Print<T>(IEnumerable<T> values)
//{
//    foreach(var value in values)
//    {
//        Console.WriteLine(value.ToString());
//    }
//}

//static string Do(ILinearDataStructureSearch<int> alg, IEnumerable<int> data, int key)
//{
//    string results = "";
//    sw.Start();
//    int x = alg.RecursiveSearch(data, key,0);
//    sw.Stop();
//    results = $"{sw.Elapsed.TotalNanoseconds} ns at {data.Count()} elements.";
//    sw.Reset();
//    return results;
//}