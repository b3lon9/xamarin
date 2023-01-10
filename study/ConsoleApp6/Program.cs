using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // virtual : 부모 클래스의 메서드를 자식에서 재정의하도록 
            // override : 자식 클래스에서 메서드를 재정의 하겠다는 표시
            parent p = new parent();
            p.show();

            child c = new child();
            c.show();

            child2 c2 = new child2();
            c2.show();

            // sealed를 사용하면 더이상 하위 클래스에서 override할 수 없음

        }
        class parent
        {
            virtual public void show()
            {
                Console.WriteLine("부모 클래스 show메서드 호출...");
            }
        }

        class child : parent
        {
            public override void show()
            {
                base.show();
            }
        }

        class child2 : parent
        {
            public sealed override void show()
            {
                Console.WriteLine("자식 클래스 show메서드 호출...");
            }
        }

        class grandchild : child2
        {
            // 멤버가 봉인되어 있어 재정의 할 수 없음
            //override public void show()
            //{

            //}
        }
    }
}
