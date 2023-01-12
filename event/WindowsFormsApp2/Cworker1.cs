using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Cworker1
    {
        // 기능만 가질 수 있도록 Interface를 매개타입으로 받음
        public void send(IWorker worker)
        {
            // worker2에게 주는것
            worker.receive();
        }
    }
}
