using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int add(int a, int b)
        {
            Console.WriteLine("im add !!");
            return a + b;
        }

        int minus(int a, int b)
        {
            Console.WriteLine("im minus !!");
            return a - b;
        }

        // 반환 타입과 매개변수가 동일하면 '대표'하는 함수를 만들 수 있음
        delegate int calc_dele(int a, int b);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 버튼을 누르면 ~
            int result;

            calc_dele calc = new calc_dele(add);    // 함수명을 넣음
            result = calc(20, 10);

            Console.WriteLine("result : " + result);

            calc = new calc_dele(minus);
            result = calc(20, 10);

            Console.WriteLine("result : {0}", result);
            /*
             result : 30
             result : 10
             */

            calc_dele c1 = new calc_dele(add);
            calc_dele c2 = new calc_dele(minus);

            calc_dele c3 = c1;
            result = c3(10, 20);
            Console.WriteLine("c3 _ result : " + result);

            c3 += c2;   // c3 = c3 + c2 가 가능함
            result = c3(50, 30);
            Console.WriteLine("c3(50,30) : " + result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
