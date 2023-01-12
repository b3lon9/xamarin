using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    // plug-in 이라고 생각
    internal class CWorker3 : INotify
    {
        public event OnNotify_dele OnNotify;
        public CWorker3()
        {
        
        }

        public void testc()
        {
            if (OnNotify != null)
                OnNotify();
            else
                Console.WriteLine("event not connected");
        }
    }
}
