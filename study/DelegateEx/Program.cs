// See https://aka.ms/new-console-template for more information
using System;

namespace DelegateEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            // 객체생성
            CircleCaculator circleCalculator = new CircleCaculator();

            // delegate 생성
            CircleDelegate circleDelegate = new CircleDelegate(circleCalculator.GetArea);
            double circleArea = circleDelegate(10);     // GetArea함수로 계산 됨

            Console.WriteLine($"curcleArea : {circleArea}");

            circleDelegate = new CircleDelegate(circleCalculator.GetLength);
            double circleLength = Math.Round(circleDelegate(10), 2);
            Console.WriteLine($"circleLength : {circleLength}");
        }
    }
}