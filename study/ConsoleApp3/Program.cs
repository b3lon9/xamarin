using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 이항 연산자
            int a = 28;
            int b = 10;

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            // 28 + 10 = 38

            // 실수 연산
            float f1 = 3.141592f;
            float f2 = 2.141592f;
            Console.WriteLine("{0} % {1} = {2}", f1, f2, f1 % f2);
            // 3.141592 % 2.141592 = 1
            // 타입 확인하는 것은 어떻게할까...?

            /*
             debug모드
            - 디버그할 라인 클릭
            - F9 눌러 브레이크 포인트 지정
            - F5 누르면 디버그 됨(다시 누르면 다음 브레이크 포인트로 이동)
            - F10 누르면 다음 라인까지 코드실행
            - F11 누르면 다른 참조된 라이브러리까지 이동되어 코드 실행
             */

            // 비트 이항 연산
            byte aa = 15;
            byte bb = 5;
            Console.WriteLine("aa : {0}", aa);
            // Convert.ToString(target, number)
            Console.WriteLine("Convert.ToString(aa, 2) : {0}", Convert.ToString(aa, 2));
            Console.WriteLine("Convert.ToString(aa, 10) : {0}", Convert.ToString(aa, 10));
            Console.WriteLine("Convert.ToString(aa, 2).PadLeft(8, '0') : {0}", Convert.ToString(aa, 2).PadLeft(8, '0'));
            Console.WriteLine("Convert.ToString(aa, 2).PadRight(8, '0') : {0}", Convert.ToString(aa, 2).PadRight(8, '0'));
            /*
            Convert.ToString(aa, 2) : 1111
            Convert.ToString(aa, 10) : 15
            Convert.ToString(aa, 2).PadLeft(8, '0') : 00001111
            Convert.ToString(aa, 2).PadRight(8, '0') : 11110000
             */


            // 삼항 연산자
            int num1 = 10;
            int num2 = 20;

            int result = (num1 > num2) ? 99 : 1;
            Console.WriteLine("result : {0}", result);
            // result : 1

            /*
            [ if문 ]
             if ( a > b )
            {

            } 
            else if ( a < b)
            {
            }
            else
            {
            }

            [ switch문 ]
            switch (조건식)
            {
                case 조건식:
                {
                    break;
                }
                default:
                {

                }

            }
             */
            int xx = 13;

            switch (xx)
            {
                case 10:
                    {
                        Console.WriteLine("xx is 10");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("xx is 11");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("xx is 12");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("xx is 13");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("no anyone");
                        break;
                    }
            }
        }
    }
}