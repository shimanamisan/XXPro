using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 配列
        private void button1_Click(object sender, EventArgs e)
        {
            int aaa = 1;

            // 新しい配列を生成（型や許容できる値の個数も指定する）
            int[] values = new int[3];

            values[0] = 10;
            values[1] = 20;
            values[2] = 30;
            // values[3] = 40; // 3つまで入る配列なので、4つ目は入れれない


            // 省略した書き方
            int[] values2 = { 1, 2, 4 }; // int[3]の配列の中に 1,2,4 の数値が入っている
            // 配列の中の個数を取得する
            MessageBox.Show(values2.Length.ToString());
        }
    }
}
