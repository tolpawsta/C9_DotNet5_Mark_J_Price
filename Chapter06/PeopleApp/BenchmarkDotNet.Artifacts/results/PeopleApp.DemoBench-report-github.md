``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Athlon(tm) II X4 635 Processor, 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.201
  [Host]     : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT
  Job-SLIZWI : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT

Runtime=.NET Core 5.0  

```
| Method |     N |      Mean |     Error |    StdDev |
|------- |------ |----------:|----------:|----------:|
| **Sha256** |  **1000** |  **7.067 μs** | **0.0465 μs** | **0.0435 μs** |
|    Md5 |  1000 |  2.922 μs | 0.0103 μs | 0.0096 μs |
| **Sha256** | **10000** | **66.275 μs** | **0.4873 μs** | **0.4559 μs** |
|    Md5 | 10000 | 25.260 μs | 0.0809 μs | 0.0676 μs |
