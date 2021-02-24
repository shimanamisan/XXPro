using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        // 動的配列
        private void Form1_Load(object sender, EventArgs e)
        {
            // System.Collections.Generic; が読み込まれていると使える
            // Tには値の型を入れる
            List<int> valuse = new List<int>();
            // 値を追加
            valuse.Add(10);
            valuse.Add(20);
            valuse.Add(50);
            valuse.Add(51);
            valuse.Add(52);

            // 配列内の要素数を取得
            MessageBox.Show(valuse.Count.ToString());

            // インデックス指定で値を取得
            MessageBox.Show(valuse[2].ToString());

            // 値を指定して削除
            valuse.Remove(20);

            // インデックスを指定して削除
            valuse.RemoveAt(3);

            // 全部削除
            // valuse.Clear();
        }
    }
}
