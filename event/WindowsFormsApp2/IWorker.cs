using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    // interface는 약속이다.
    // 내가 만든 클래스가 형태를 가질 수 있도록 하는 약속
    internal interface IWorker
    {
        void receive();
    }

    public delegate void OnNotify_dele();

    public interface INotify
    {
        event OnNotify_dele OnNotify;
    }
}
