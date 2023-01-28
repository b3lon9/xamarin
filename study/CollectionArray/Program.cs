using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);

            for(int i=3; i < 10; i++)
            {
                arrayList.Add(i);
            }

            for (int i=0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"arrayList[{i}] : {arrayList[i]}");
            }

            int sum = 0;
            foreach(int i in arrayList)
            {
                sum += i;
            }

            Console.WriteLine("sum : {0}", sum);

            // insert
            arrayList.Insert(2, 30);    // index '2'위치에 30이 넣어지고 나머지는 뒤로 밀린다


            arrayList.RemoveAt(2);    // 다시 index '2'위치 값을 삭제
            arrayList.Remove(2);      // 값 중에 '2'인 값을 삭제

            // 가장 중요한 것은 데이터를 얼마든지 줄이거나 늘일 수 있고
            // 중복데이터를 허용함

        }
    }
}
