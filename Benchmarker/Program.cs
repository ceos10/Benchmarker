using BenchmarkDotNet.Running;
using Benchmarker.Benchmarks;

namespace Benchmarker;

public class Program
{
    static void Main(string[] args)
    {
        //BenchmarkRunner.Run<ConcatenationTest>();
        BenchmarkRunner.Run<EnumTest>();
    }
}