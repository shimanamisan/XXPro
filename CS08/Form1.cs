using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 数値の型
            byte byteValue = 255; // 255まで値が入る
            // byte byteValue2 = 256; // 256はエラーになる

            //　
            short shortValue = 10;
            short shortMax = short.MaxValue; // 最大値の32767が代入される

            // ushort ushortValue = -1; // マイナスを含めない

            int intValue = -10; // マイナスを含めることができる
            int intMaxValue = int.MaxValue; // 最大値が代入される

            uint uintValue = -10; // マイナスは使用できない

            // 同様にマイナスを含めることができる型と、そうでない型がある
            long longValue = -10;
            ulong ulongValue = 10;

            // 浮動小数点型
            float floatValue = 1.2334455f; // 明示的に使用する場合は末尾にfを記述しないと、double型と認識されてエラーになる
            double doubleValue = 1.23455d; // 末尾に明示的にdとしても良い
            decimal decimalValue = 1.2345m; // decimalも末尾にmをつける必要がある

            // Boolean
            bool boolValue = false; // true false しか入らない

            if (boolValue)
            {
                // trueの時

            }

            if (!boolValue)
            {
                // falseの時

            }

            // String型
            string strValue = "sfasdfasあああ";
            string strValue1 = "12234"; // 数字なので数値とは全く別物
        }
    }
}
