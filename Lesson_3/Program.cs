using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            PointClass pointClass = new PointClass();
            pointClass.X = 12;
            pointClass.Y = 12;

            PointStruct pointStruct = new PointStruct();
            pointStruct.dX = 13.12;
            pointStruct.dY = 13.12;

            pointStruct.fX = 13.13f;
            pointStruct.fY = 13.13f;

            ClassDist classDist = new ClassDist();

            classDist.PointDistanceClassFloat(pointClass, pointClass);

            classDist.PointDistanceDouble(pointStruct, pointStruct);

            classDist.PointDistanceStructFloat(pointStruct, pointStruct);

            classDist.PointDistanceStructFloatNoSQRT(pointStruct, pointStruct);
        }
    }
}
