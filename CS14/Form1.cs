using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // テキストボックスに入力された値をint型に変換して変数に格納
            int value = Convert.ToInt32(textBox1.Text);

            if (value == 10)
            {
                MessageBox.Show("10です");
            }

            else if (value == 20)
            {
                MessageBox.Show("20です");
            }

            else
            {
                MessageBox.Show("どれでもない");
            }

            switch (value)
            {
                case 10:
                    MessageBox.Show("10です");
                    break;

                case 20:
                    MessageBox.Show("20です");
                    break;

                default:
                    MessageBox.Show("どれでもない");
                    break;
            }
        }
    }
}
