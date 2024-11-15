﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace cs_Form
{
    internal class testlabel:Label
    {
        public testlabel(string str,int x, int y, int widht, int height)
        {
          
            //ボタン内に文字を表示させる

            Text = str;


            //ボタンの生成場所を指定
            Location = new Point(x, y);

            //ボタンの大きさ
            Size = new Size(widht, height);
        }
        /// <summary>
        /// ラベルの文字更新関数
        /// </summary>
        /// <param name="str"></param>
        public void TextUpdate(string str)
        {
            Text = str;
        }
    }

}
