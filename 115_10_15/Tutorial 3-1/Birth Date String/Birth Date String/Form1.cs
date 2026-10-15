using System;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        // 初始化表單及所有視覺化元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 將使用者輸入的出生日期資料組合後顯示在輸出標籤中。
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 依照星期、月份、日期及年份的順序組合日期字串。
            string output;

            output = dayOfWeekTextBox.Text + "," + monthTextBox.Text + "" + dayOfMonthTextBox.Text + "," + yearTextBox.Text;

            // 將組合完成的日期顯示在表單上。
            dateOutputLabel.Text = output;
        }

        // 清除所有輸入欄位及日期輸出內容。
        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text ="";
            yearTextBox.Text = "";

            dateOutputLabel.Text = "";
        }

        // 關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 日期輸出標籤的點擊事件，目前不需要額外處理。
        private void dateOutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
