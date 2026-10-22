using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有控制項。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //計算平均的邏輯可在此撰寫。
            double test1, test2, test3, average;//宣告變數以儲存三個測驗成績與平均值。

            try
            {


                test1 = double.Parse(test1TextBox.Text);//從第一個測驗輸入欄位取得成績。
                test2 = double.Parse(test2TextBox.Text);//從第二個測驗輸入欄位取得成績。
                test3 = double.Parse(test3TextBox.Text);//從第三個測驗輸入欄位取得成績。

                average = (test1 + test2 + test3) / 3;//計算三個測驗成績的平均值。
                averageLabel.Text = average.ToString("F1");  //將平均值顯示在標籤上。
            }
            catch (Exception ex)
            {
                //如果輸入的成績無法轉換為數字,顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三次測驗的輸入內容與平均分數結果。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
