using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Cworker1
    {
        public void send(CWorker2 worker2)
        {
            // worker2에게 주는것
            worker2.receive();
        }
    }
}
