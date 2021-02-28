using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;

            while( i < 10)
            {
                i++;

                if (i == 3)
                {
                    // ループを飛ばす
                    continue;
                }

                if (i == 5)
                {
                    // ループの処理を抜ける
                    // 5でbreakで入るのでメッセージボックスには4までが表示される
                    break;
                }

                MessageBox.Show(i.ToString());
            }
        }
    }
}
