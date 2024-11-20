using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace cs_Form
{
    internal class TestButton : Button
    {
        Form1 _form1;


        public TestButton( Form1 form1,int x,int y, int widht, int height, int id )
        {

            _form1= form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;
           
            

            //ボタン内に文字を表示させる

            //string[] iw = new string[10];
            //iw[0] = "a";
            //iw[1] = "b";
            //iw[2] = "c";
            //iw[3] = "d";
            //iw[4] = "e";
            //iw[5] = "f";
            //iw[6] = "g";
            //iw[7] = "h";
            //iw[8] = "i";
            //iw[9] = "j";
           
            Text = id.ToString();



            //int k = 0;
            //for( k =0; k > 1000 ; k++ )
            //{
            //    int J = 0;
            //    Text = ($"{J}");
            //    J ++;

            //}




            //ボタンの生成場所を指定
            Location = new Point(x,y);

            //ボタンの大きさ
            Size = new Size(widht,height);
        }

        public void OnClick(object sender, EventArgs s)
        {

            string t =_form1.ButtonLabelReplacement(Text);

            Text = t;

            _form1.LabelTextUpdate(Text);


        }
       


        
      


    }
}
