using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // struct형 : 완제품
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("int형 Max : {0} ~ Min : {1} size : {2}byte", int.MaxValue, int.MinValue, sizeof(int));
            /*
            [result]
            10
            int형 Max : 2147483647 ~ Min : -2147483648 size : 4byte
             */

            // void Console.WriteLine(string format, params object[] arg)
            // sizeof() 함수는 할당 데이터의 크기를 확인 함수

            /*                                          byte
             * byte     부호없는 정수     struct      1(8bit)     0 ~ 255
             * sbyte    정수              struct      1(8bit)     -128 ~ 127
             * short    정수              struct      2(16bit)    -32,768 ~ 32,767
             * ushort   부호없는 정수     struct      2(16bit)    0 ~ 65535
             * int      정수              struct      4(32bit)    -2,147,483,648 ~ 2,147,483,647
             * uint     부호없는 정수     struct      4(32bit)    0 ~ 4,294,967,295
             * long     정수              struct      8(64bit)    -922,337,203,685,477,508 ~ 922,337,203,685,477,507
             * ulong    부호없는 정수     struct      8(64bit)    0 ~ 18,446,744,073,709,551,615
             * char     문자              struct      2(16bit)    
             * float    실수              struct      4(32bit)    -3.402823e38 ~ 3.402823e38
             * double   실수              struct      8(64bit)    -1.79769313486232e308 ~ 1.79769313486232e308
             * decimal  실수              struct      16(128bit)  -79228162514264337593543950335 ~ 79228162514264337593543950335
             * bool     논리              struct      1(8bit)     true, false
             * string   문자열            class
             * object   객체              class
             */

            // C#은 기본적으로 double형으로 인식을 하기때문에 타입 지정을 해주어야 함
            double b = 1.234567;
            float c = (float)b;
            int d = (int)b;

            Console.WriteLine("double : {0}", b);
            Console.WriteLine("float : {0}", c);
            Console.WriteLine("int : {0}", d);

            /*
             * [result]
             double : 1.234567
            float : 1.234567
            int : 1
             */
        }
    }
}
