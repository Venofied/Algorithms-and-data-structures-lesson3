``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.18363.720 (1909/November2019Update/19H2)
AMD FX(tm)-6300, 1 CPU, 6 logical and 3 physical cores
.NET Core SDK=3.1.201
  [Host] : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT  [AttachedDebugger]


```
|                  Method | pointOne | pointTwo | Mean | Error |
|------------------------ |--------- |--------- |-----:|------:|
| PointDistanceClassFloat |       12 |       12 |   NA |    NA |

Benchmarks with issues:
  ClassDist.PointDistanceClassFloat: DefaultJob [pointOne=12, pointTwo=12]
