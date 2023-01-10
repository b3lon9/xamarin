using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    interface ITest
    {
        void Function();
        void Function2();
    }

    interface ITest2
    {
        void Function2();
    }

    class TestClass:ITest, ITest2
    {
        public void Function()
        {
            Console.WriteLine("호호호");
        }

        public void Function2()
        {
            Console.WriteLine("하하하");   // 둘 중 어느 인터페이스일까
        }
    }

    // 추상클래스
    public abstract class Gun
    {
        public int number = 1;
        public abstract void Fire();
        public void Reload()
        {
            Console.WriteLine("장전!!!");
        }
    }

    class AutoGun : Gun
    {
        override public void Fire()
        {
            Console.WriteLine("AutoGun 다다다다");
        }
    }

    class LaserGun : Gun
    {
        public override void Fire()
        {
            Console.WriteLine("LaserGun 쥐이이이잉");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 난 인터페이스를 알지만 설명할 수 없다.
            // 인터페이스는 그냥... 동시 가능성 기능이라고 보면 됨
            TestClass tc = new TestClass();
            tc.Function();
            tc.Function2();
            Console.WriteLine();

            // 인스턴스화 할 수 없지만 참조자 형으로 사용 가능
            ITest interfaceA = tc;
            interfaceA.Function();
            interfaceA.Function2();

            ITest2 interfaceB = tc;
            interfaceB.Function2();

            // 추상클래스
            // 왜 사용할까?
            // 클래스 자체로 추상 메소드를 강제할 수 있고,
            // 구현 되지 않은 부분을 컴파일러가 알려준다?
            // 이렇게 말하면 누가 이해하니?

            // 해당 클래스의 필요한 프로퍼티나 메서드를 정의하고
            // 파생 클래스에서 해당 프로퍼티와 메서드를 재정의하여 사용

            // 클래스를 설계하는 것이라고 보면 됨
            Gun g = new AutoGun();
            g.Fire();
            g.Reload();

            if (g is LaserGun)
            {
                LaserGun laser = g as LaserGun;
                if (laser != null)
                {
                    laser.Fire();
                }
                else
                {
                    Console.WriteLine("LaserGun 없습니다");
                }
            }
        }
    }
}
