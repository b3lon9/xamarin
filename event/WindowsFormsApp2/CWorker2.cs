using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class CWorker2:IWorker
    {
        int m_nCount;

        public delegate void DeleFull();
        public event DeleFull OnFull;   // delegate이름을 선언해줌

        public void receive()
        {
            m_nCount++;

            Console.WriteLine("receive ..." + m_nCount);
            if (m_nCount == 5)
            {
                if (OnFull != null)
                {                // 5개 받으면 이벤트 발생
                    OnFull();   // 이렇게만 작성하면 이벤트 발생
                }
                else
                {
                    Console.WriteLine("Event Not Connect...");
                }
            }
        }

    }
}
