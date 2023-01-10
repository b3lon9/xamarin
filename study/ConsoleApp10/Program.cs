using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 에러 처리
            // try ~ catch, throw, finally (Exception Handling)
            int[] arr = { 1, 2, 3 };

            try
            {
                arr[4] = 4;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Occur {0}", e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception Occur {0}", e.Message);
            }
            // Exception Occur 인덱스가 배열 범위를 벗어났습니다.


            // throw
            
            try
            {
                CheckPw(111);
                CheckPw(1234);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
            finally
            {
                Console.WriteLine("finally block");
            }
            /*
             pw가 틀려요
             finally block       
             */
        }
        private static int password = 1234;

        static void CheckPw(int pw)
        {
            if (password != pw)
            {
                throw new Exception("pw가 틀려요 ");
            } 
            else
            {
                Console.WriteLine("비밀번호 인증완료 ! ");
            }
        }
    }
}
