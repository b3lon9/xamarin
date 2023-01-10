using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // [한정자] [반환형식] [이름] ([매개변수])

            // 액세스 한정자 : public private protected (default : private)
            // static은 정적메소드로 프로그램 실행시 자동으로 메모리에 생성됨
            Console.WriteLine(plus(5, 10));

            int t = 20;

            amt(t);
            Console.WriteLine("first test : {0}", t);

            amt(ref t);
            Console.WriteLine("ref test : {0}", t);

            // ref 는 초기화된 값을 참조하지만 out은 초기화하지 않아도 됨
            int nA = 0;
            Console.WriteLine("no init A : {0}", nA);
            initA(out nA);
            Console.WriteLine("init A : {0}", nA);

            object[] objArr = { 777, 888, 'k', "helloo" };
            plus(objArr);
        }
        static int plus(int a, int b)
        {
            return a + b;
        }

        // overloading
        static float plus(float a, float b)
        {
            return a + b;
        }

        // call by value, call by reference, out, in
        static private void amt(int a)
        {
            a += 333;
        }

        static private void amt(ref int a)
        {
            a += 555;
        }

        static private void initA(out int a)
        {
            a = 777;
        }
        
        // params : 매개변수 사용지정을 할 수 있음
        static private void plus(params object[] obj)
        {
            for (int i=0; i<obj.Length; i++)
            {
                Console.WriteLine($"음흠흠?? : {obj[i]}");
            }
        }
    }
}

/*
[result]
15
first test : 20
ref test : 575
no init A : 0
init A : 777
음흠흠?? : 777
음흠흠?? : 888
음흠흠?? : k
음흠흠?? : helloo
 */