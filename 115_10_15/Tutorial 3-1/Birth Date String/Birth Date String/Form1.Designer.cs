namespace Birth_Date_String
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的元件容器。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 釋放表單使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設定表單元件及其外觀的設計工具方法。
        /// 請勿使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 暫停表單配置，待所有元件設定完成後再恢復。
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(583, 50);
            this.dayOfWeekTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(508, 55);
            this.dayOfWeekTextBox.TabIndex = 0;
            // 月份輸入欄位。
            this.monthTextBox.Location = new System.Drawing.Point(583, 188);
            this.monthTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(508, 55);
            this.monthTextBox.TabIndex = 1;
            // 日期輸入欄位。
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(583, 325);
            this.dayOfMonthTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(508, 55);
            this.dayOfMonthTextBox.TabIndex = 2;
            // 年份輸入欄位。
            this.yearTextBox.Location = new System.Drawing.Point(583, 462);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(508, 55);
            this.yearTextBox.TabIndex = 3;
            // 星期提示文字。
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(47, 62);
            this.dayOfWeekPromptLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(164, 45);
            this.dayOfWeekPromptLabel.TabIndex = 4;
            this.dayOfWeekPromptLabel.Text = "輸入星期";
            // 月份提示文字。
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(47, 200);
            this.monthPromptLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(236, 45);
            this.monthPromptLabel.TabIndex = 5;
            this.monthPromptLabel.Text = "輸入月份名稱";
            // 日期提示文字。
            this.dayOfMonthPromptLabel.AutoSize = true;
            this.dayOfMonthPromptLabel.Location = new System.Drawing.Point(47, 338);
            this.dayOfMonthPromptLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            this.dayOfMonthPromptLabel.Size = new System.Drawing.Size(308, 45);
            this.dayOfMonthPromptLabel.TabIndex = 6;
            this.dayOfMonthPromptLabel.Text = "輸入日期（數字）";
            // 年份提示文字。
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(47, 475);
            this.yearPromptLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(164, 45);
            this.yearPromptLabel.TabIndex = 7;
            this.yearPromptLabel.Text = "輸入年份";
            // 日期結果顯示區域。
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(47, 612);
            this.dateOutputLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(1047, 147);
            this.dateOutputLabel.TabIndex = 8;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateOutputLabel.Click += new System.EventHandler(this.dateOutputLabel_Click);
            // 顯示日期按鈕。
            this.showDateButton.Location = new System.Drawing.Point(128, 825);
            this.showDateButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(292, 125);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "顯示日期";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 清除按鈕。
            this.clearButton.Location = new System.Drawing.Point(425, 825);
            this.clearButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(292, 125);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 離開按鈕。
            this.exitButton.Location = new System.Drawing.Point(721, 825);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(292, 125);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 表單本身的設定。
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 1025);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "出生日期字串";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

