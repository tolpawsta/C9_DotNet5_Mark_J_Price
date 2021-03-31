``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Athlon(tm) II X4 635 Processor, 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.201
  [Host] : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT

Job=CoreRt 5.0  Runtime=CoreRt 5.0  

```
| Method |     N | Mean | Error |
|------- |------ |-----:|------:|
| **Sha256** |  **1000** |   **NA** |    **NA** |
|    Md5 |  1000 |   NA |    NA |
| **Sha256** | **10000** |   **NA** |    **NA** |
|    Md5 | 10000 |   NA |    NA |

Benchmarks with issues:
  Md5VsSha256.Sha256: CoreRt 5.0(Runtime=CoreRt 5.0) [N=1000]
  Md5VsSha256.Md5: CoreRt 5.0(Runtime=CoreRt 5.0) [N=1000]
  Md5VsSha256.Sha256: CoreRt 5.0(Runtime=CoreRt 5.0) [N=10000]
  Md5VsSha256.Md5: CoreRt 5.0(Runtime=CoreRt 5.0) [N=10000]
