using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*TestButton testButton = new TestButton(0,0,100,100);

            Controls.Add(testButton);

            TestButton testButton2 = new TestButton(100,100,100,100);

            Controls.Add(testButton2);*/

            int a;

            /*for (a = 1;  a < 10; a++)
             {
                 int b;
                 b = 0;
                 int c;
                 c = 0;
                 int d;
                 d = 0;
                 int e = 0;
                 TestButton testButton = new TestButton(b, c, d, e);

                 Controls.Add(testButton);

                 b = +10;
                 c = +10;
                 d = +10;
                 e = +10;

             }*/

            for (a = 0; a < 1000; a++)
            {

                TestButton testButton = new TestButton((a % 100) * 100, (a / 100) * 100, 100, 100, a);

                Controls.Add(testButton);

              

            }
            






        }
    }
}
