using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    delegate void EventHandler(int number, string message);
    
    // 방문자 이벤트
    class Visitor
    {
        public event EventHandler EventCall;

        public void VisitorCheck(int VisitorNum)
        {
            if (VisitorNum % 3 == 0)
            {
                EventCall(VisitorNum, "방문자");
            }
        }
    }
    
    class Celebration
    {
        public void VisitorEvent(int number , string message)
        {
            if (number == 9)
            {
                Console.WriteLine("--- ---");
                Console.WriteLine("{0}번째 {1}로 이벤트 당첨..?", number, message);
            }
            else
            {
                Console.WriteLine("방문자 이벤트 발생!");
            }
        }
    }

    internal class Program
    {
        static void Function()
        {
            // Function
            Console.WriteLine("Function() ...");
        }

        static void Function2()
        {
            Console.WriteLine("Function2()...");
        }

        delegate void Worker();
        static void Main(string[] args)
        {
            Worker w1 = new Worker(Function);
            w1();

            w1 += new Worker(Function2);
            w1();

            // 이벤트를 받을 객체 인스턴스
            Celebration celub = new Celebration();

            // 이벤트 발생 인스턴스
            Visitor vis = new Visitor();

            vis.EventCall += new EventHandler(celub.VisitorEvent);

            for (int i=0; i<10; i++)
            {
                vis.VisitorCheck(i);
            }
        }
    }
}
