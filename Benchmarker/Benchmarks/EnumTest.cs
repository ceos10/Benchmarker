using BenchmarkDotNet.Attributes;
using Benchmarker.Enums;
using FastEnumUtility;

namespace Benchmarker.Benchmarks;

[MemoryDiagnoser(false)]
public class EnumTest
{
    [Benchmark]
    public string EnumToString()
    {
        return Color.Lime.ToString();
    }

    [Benchmark]
    public string EnumToStringFast()
    {
        return FastEnum.GetName(Color.Lime);
    }

    [Benchmark]
    public bool EnumIsDefined()
    {
        return Enum.IsDefined(typeof(Color), Color.Lime);
    }

    [Benchmark]
    public bool EnumIsDefinedFast()
    {
        return FastEnum.IsDefined(Color.Lime);
    }

    [Benchmark]
    public bool EnumCouldParse()
    {
        return Enum.TryParse("Lime", false, out Color _);
    }

    [Benchmark]
    public bool EnumCouldParseFast()
    {
        return FastEnum.TryParse("Lime", out Color _);
    }
}
