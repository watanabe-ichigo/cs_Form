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

        testlabel _testLabel;

        TextBox _textBox;

        TestButton _button;

        



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

            //for (a = 0; a < 10; a++)
            //{


            //    TestButton testButton = new TestButton(this,(a % 5) * 100, (a / 5) * 100, 100, 100,a);

            //    Controls.Add(testButton);
                  
            //}

          





            _testLabel = new testlabel("ラベルです", 10, 300, 100, 500);
            Controls.Add(_testLabel);

            _textBox = new TestTextbox("テキストボックスです", 10, 300, 500, 100);
            Controls.Add(_textBox);



            

            //Label label = new Label();
            //label.Location = new Point(30, 400);
            //label.Text = "ラベルです";
            //Controls.Add(label);


        }

        

        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
        public void ButtonTextUpdate(string id)
        {
            _button.TextUpdate1(id);
        }

    }
}
