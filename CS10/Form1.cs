using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // キャスト
        private void button1_Click(object sender, EventArgs e)
        {
            double d1 = 1.9d;
            // 明示的にキャストする
            int aaa = (int)d1;
        } // このあたりでブレークポイントを付けてみる


        // Parse
        private void button2_Click(object sender, EventArgs e)
        {
            // string value = "あああ"; // 例外が発生する
            // string value = "10.1"; // 例外が発生する
            // string value = null; // 例外が発生する

            string value = "10";
            // intに変換
            int intValeu = int.Parse(value);
        }


        // TryParse
        private void button3_Click(object sender, EventArgs e)
        {
            string value = "10";
            // intに変換した後の変数を用意する必要がある
            int intValue;
            // valueが正しく変換されたら true そうでなければ false が返ってくる
            bool result = int.TryParse(value,out intValue); // outというのはresultに出力されるという意味
        }


        // Convert
        private void button4_Click(object sender, EventArgs e)
        {
            // string value = "10.4"; // 例外が発生

            // Parseではnullは例外になるが、Convertでは0が返ってくる
            string value = null;

            // string value = "10";

            // 何ビットに変換するか指定できる
            int intValeu = Convert.ToInt32(value);
        }

    }
}
