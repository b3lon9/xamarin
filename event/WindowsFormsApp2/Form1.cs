﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Cworker1 worker1;
        CWorker2 worker2;
        public Form1()
        {
            InitializeComponent();

            worker1 = new Cworker1();
            worker2 = new CWorker2();

            // worker2의 'event'를 만져줌
            worker2.OnFull += new CWorker2.DeleFull(OnFull);
        }

        void OnFull()
        {
            // event에서 실행될 함수
            Console.WriteLine("OnFull..!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker1.send(worker2 as IWorker);
        }
    }
}
