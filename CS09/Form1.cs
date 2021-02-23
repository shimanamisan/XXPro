using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        //　追加したボタン
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;

            MessageBox.Show("a= " + a); // 10
            MessageBox.Show("b= " + b); // 20

            a = b;

            MessageBox.Show("a= " + a); // 20
            MessageBox.Show("b= " + b); // 20

            b = 30;

            MessageBox.Show("a= " + a); // 20
            MessageBox.Show("b= " + b); // 30

        }

        // 参照型のボタン
        private void button2_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            Other b = new Other();

            a.Value = 10;
            b.Value = 20;

            MessageBox.Show("a= " + a.Value); // 10
            MessageBox.Show("b= " + b.Value); // 20

            a = b; // インスタンスbのアドレスの参照先に変更されている

            MessageBox.Show("a= " + a.Value); // 20
            MessageBox.Show("b= " + b.Value); // 20

            b.Value = 30;
            MessageBox.Show("a= " + a.Value); // 変数aに格納されているインスタンスはbの参照先に書き換わっているので、インスタンスbと同じ値が出力される
            MessageBox.Show("b= " + b.Value); // 30

        }

        private void OtherMethod(Other other)
        {
            other.Value = 55;
        }

        private void ValueMethod(int other)
        {
            other = 66;
        }

        public class Other
        {
            public int Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            a.Value = 10;
            // 関数内でインスタンス内の値が変更されている
            OtherMethod(a);

            MessageBox.Show("a= " + a.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 10;

            // 値がコピーされているだけなので、大元の変数には影響がない
            ValueMethod(a);

            MessageBox.Show("a= " + a);
        }
    }
}
