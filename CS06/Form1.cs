using System.Windows.Forms;

namespace CS06
{
    public partial class Form1 : Form
    {
        private int _value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private int GetValue()
        {
            _value++;

            // メソッドで型を指定したら必ず値を返さないといけない
            return 1;
        }

        // メッセージを表示させるだけなど、値を返さない場合はvoidを指定する
        private void SetValue()
        {
            MessageBox.Show("Hello World");
        }
    }
}
