using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    // 참조하고 하는 메서드 형태와 동일하게 형태를 맞춰줌
    delegate double CircleDelegate(double r);
    class CircleCaculator
    {
        double circleRatio = 3.14d;
        
        public CircleCaculator()
        {
            Console.WriteLine("===CircleCaculator");
        }

        public double GetArea(double r)
        {
            // 넓이, 반지름 * 반지름
            return r * r * circleRatio;
        }

        public double GetLength(double r)
        {
            // 둘레, 반지름 * 원주율
            return r * 2 * circleRatio;
        }
    }
}
