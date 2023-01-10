using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        // 왜 struct를 사용할까?
        // kotlin의 data class struct를 참조한 것 같다.
        // 구조체는 데이터만을 위한 데이터 집합체로 사용되며
        // 편의를 위해 공개적으로 메서드를 사용하는 경우가 많음
        struct TestStruct
        { 
            public int number;
            public void show()
            {
                Console.WriteLine("Number : {0}", this.number);
            }
               
            public TestStruct(int number)
            {
                this.number = number;            }
        }
        static void Main(string[] args)
        {
            // 선언만으로 생성,
            TestStruct testStruct;
            testStruct.number = 15;
            testStruct.show();

            // 초기화
            TestStruct testStruct1 = new TestStruct();
            testStruct1.number = 100;
            testStruct1.show();

            // 깊은 복사
            TestStruct testStruct2 = testStruct;
            testStruct2.number = 77;
            testStruct.show();
            testStruct2.show();

            // new 생성자 정의
            TestStruct testStruct3 = new TestStruct(33);
            testStruct3.show();

            // 구조체 배열
            TestStruct[] testStructArr = { new TestStruct(99), testStruct2, new TestStruct(3) };

            foreach (TestStruct t in testStructArr)
            {
                t.show();
            }

            // =======
            // operator : 연산자를 오버로드 하는 
            Vector2 vecPosition = new Vector2(19.2f, 3.5f);
            Console.WriteLine(vecPosition);

            vecPosition += new Vector2(0.5f, 60.0f);
            Console.WriteLine(vecPosition);
            /*
             * 19.20, 3.500
                19.70, 63.500
             */
        }

        struct Vector2
        {
            public float x;
            public float y;

            public Vector2(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            // 구조체도 object를 상속받음
            public override string ToString()
            {
                return string.Format("{0:F2}, {1:F3}", this.x, this.y);
            }

            // 덧셈끼리 연산
            public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
            {
                Vector2 nv = new Vector2();
                nv.x = lhs.x + rhs.x;
                nv.y = lhs.y + rhs.y;
                return nv;
            }
        }
    }
}
