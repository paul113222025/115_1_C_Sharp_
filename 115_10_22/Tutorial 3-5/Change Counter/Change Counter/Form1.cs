using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS = 5.0m;
        const decimal TEN_CENTS = 10.0m;
        const decimal TWENTY_FIVE_CENTS = 25.0m;
        const decimal FIFTY_CENTS = 50.0m;
        private decimal total = 0.00m;//初始化總額為0。
        public Form1()
        {
            // 初始化表單元件。
            InitializeComponent();
        }

        // 處理點選五分硬幣圖片的事件。
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            decimal total = 0.00m;//初始化總額為0。
            total = total + FIVE_CENTS; // 將 5 加到總額
            totalLabel.Text = total.ToString("C");//更新總額顯示,格式化為貨幣。
        }

        // 處理點選十分硬幣圖片的事件。
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total=0.00m;// 初始化總額為 0。
            total = total + TEN_CENTS;//將 10 加入總額。
            totalLabel.Text = total.ToString("C");//更新總額顯示,格式化為貨幣。
        }

        // 處理點選二十五分硬幣圖片的事件。
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + TWENTY_FIVE_CENTS;//將25 加入總額。
            totalLabel.Text = total.ToString("C");//更新總額顯示,格式化為貨幣。
        }

        // 處理點選五十分硬幣圖片的事件。
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + FIFTY_CENTS;//將50 加入總額。
            totalLabel.Text = total.ToString("C");//更新總額顯示,格式化為貨幣。
        }

        // 處理點選離開按鈕的事件。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
