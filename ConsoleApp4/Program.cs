using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while, do while, for, foreach

            int num = 0;

            // while문
            while (num < 5)
            {
                Console.WriteLine("num : {0}", num);
                num++;

                // 제어문
                // if ( num < 5 ) break;
            }

            // for문
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("for loop : {0}", i);
            }

            // foreach문 : java의 향상된 for문과 동일
            int[] arr = { 1, 2, 3, 5, 7, 3, 2 };
            foreach(int i in arr)
            {
                Console.WriteLine("foreach : {0}", i);
            }


            // 제어문
            // break, continue, return, throw, goto

            int j = 0;

        AAA:
            Console.WriteLine("goto AAA : {0}", j);
            j++;

            if (j == 5) goto BBB;

            goto AAA;

        BBB:
            Console.WriteLine();
            Console.WriteLine("goto BBB : {0}", j);
        }
    }
}

/*
 [result]
num : 0
num : 1
num : 2
num : 3
num : 4
for loop : 0
for loop : 1
for loop : 2
for loop : 3
for loop : 4
foreach : 1
foreach : 2
foreach : 3
foreach : 5
foreach : 7
foreach : 3
foreach : 2
goto AAA : 0
goto AAA : 1
goto AAA : 2
goto AAA : 3
goto AAA : 4

goto BBB : 5
 */