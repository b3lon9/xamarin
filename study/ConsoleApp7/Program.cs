using Extension;
using System;

namespace Extension
{
    public static class IntExtension
    {
        public static int Square(this int width, int height)
        {
            return width * height;
        }
    }
}

namespace ConsoleApp7
{
    internal class Program
    {
        // 분할 클래스partial class : 동일한 클래스를 나누어 작업
        static void Main(string[] args)
        {
            Console.WriteLine($"{12.Square(8)}");
        }
        //class TestGun     // 에러 발생 ctrl + k, c
        //{
        //    public void
        //}
        partial class TestGun
        {
            public void Fire() { }
        }

        partial class TestGun
        {
            public void Fire2() { }
        }


    }
}
// 확장