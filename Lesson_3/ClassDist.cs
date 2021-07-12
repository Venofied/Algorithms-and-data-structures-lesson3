using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson_3
{
    public class ClassDist
    {
		[Benchmark]
		[Arguments(12, 12)]
		public float PointDistanceClassFloat(PointClass pointOne, PointClass pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}
		[Benchmark]
		[Arguments(13.12, 13.12)]
		public double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
		{
			double x = pointOne.dX - pointTwo.dX;
			double y = pointOne.dY - pointTwo.dY;
			return Math.Sqrt((x * x) + (y * y));
		}
		[Benchmark]
		[Arguments(13.13f, 13.13f)]
		public float PointDistanceStructFloat(PointStruct pointOne, PointStruct pointTwo)
		{
			float x = pointOne.fX - pointTwo.fX;
			float y = pointOne.fY - pointTwo.fY;
			return MathF.Sqrt((x * x) + (y * y));
		}
		[Benchmark]
		[Arguments(13.13f, 13.13f)]
		public float PointDistanceStructFloatNoSQRT(PointStruct pointOne, PointStruct pointTwo)
		{
			float x = pointOne.fX - pointTwo.fX;
			float y = pointOne.fY - pointTwo.fY;
			return ((x * x) + (y * y));
		}
	}
}
