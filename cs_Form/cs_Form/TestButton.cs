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
        public TestButton(int x,int y, int widht, int height)
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;

            //ボタン内に文字を表示させる
            Text = "ボタン";

            //ボタンの生成場所を指定
            Location = new Point(x,y);

            //ボタンの大きさ
            Size = new Size(widht,height);
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("D");
        }
       
    }
}
