using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07
{
    public partial class Form1 : Form
    {
        // ボタンをクリックしたときに値を記憶させる
        private int _count = 0;

        // 定数
        private const int AAA = 10;

        public Form1()
        {
            InitializeComponent();
        }

        // ボタン2のクリックイベント
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_count.ToString());
        }

        // ボタンクリックのイベント
        private void button1_Click(object sender, EventArgs e)
        {
            _count += 1;
        }
    }
}
