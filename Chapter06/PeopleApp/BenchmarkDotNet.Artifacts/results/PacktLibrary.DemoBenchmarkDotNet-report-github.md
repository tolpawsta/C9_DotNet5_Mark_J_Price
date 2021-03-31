``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Athlon(tm) II X4 635 Processor, 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.201
  [Host] : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT


```
|     Method |           Job |       Runtime | FinishNumber | Mean | Error | Ratio | RatioSD |
|----------- |-------------- |-------------- |------------- |-----:|------:|------:|--------:|
|   BenchFor |      .NET 4.8 |      .NET 4.8 |   1000000000 |   NA |    NA |     ? |       ? |
|   BenchFor | .NET Core 5.0 | .NET Core 5.0 |   1000000000 |   NA |    NA |     ? |       ? |
|            |               |               |              |      |       |       |         |
| BenchWhile |      .NET 4.8 |      .NET 4.8 |   1000000000 |   NA |    NA |     ? |       ? |
| BenchWhile | .NET Core 5.0 | .NET Core 5.0 |   1000000000 |   NA |    NA |     ? |       ? |

Benchmarks with issues:
  DemoBenchmarkDotNet.BenchFor: .NET 4.8(Runtime=.NET 4.8) [FinishNumber=1000000000]
  DemoBenchmarkDotNet.BenchFor: .NET Core 5.0(Runtime=.NET Core 5.0) [FinishNumber=1000000000]
  DemoBenchmarkDotNet.BenchWhile: .NET 4.8(Runtime=.NET 4.8) [FinishNumber=1000000000]
  DemoBenchmarkDotNet.BenchWhile: .NET Core 5.0(Runtime=.NET Core 5.0) [FinishNumber=1000000000]
