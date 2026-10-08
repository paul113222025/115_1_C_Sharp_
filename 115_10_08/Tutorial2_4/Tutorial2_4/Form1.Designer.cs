using System;

namespace Tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.germanpictureBox = new System.Windows.Forms.PictureBox();
            this.francepictureBox = new System.Windows.Forms.PictureBox();
            this.finlandpictureBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.germanpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // germanpictureBox
            // 
            this.germanpictureBox.Image = global::Tutorial2_4.Properties.Resources.Germany;
            this.germanpictureBox.InitialImage = global::Tutorial2_4.Properties.Resources.Germany;
            this.germanpictureBox.Location = new System.Drawing.Point(537, 102);
            this.germanpictureBox.Name = "germanpictureBox";
            this.germanpictureBox.Size = new System.Drawing.Size(230, 146);
            this.germanpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.germanpictureBox.TabIndex = 2;
            this.germanpictureBox.TabStop = false;
            this.germanpictureBox.Click += new System.EventHandler(this.germanpictureBox_Click);
            // 
            // francepictureBox
            // 
            this.francepictureBox.Image = global::Tutorial2_4.Properties.Resources.France;
            this.francepictureBox.InitialImage = global::Tutorial2_4.Properties.Resources.France;
            this.francepictureBox.Location = new System.Drawing.Point(270, 102);
            this.francepictureBox.Name = "francepictureBox";
            this.francepictureBox.Size = new System.Drawing.Size(242, 146);
            this.francepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.francepictureBox.TabIndex = 1;
            this.francepictureBox.TabStop = false;
            this.francepictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // finlandpictureBox
            // 
            this.finlandpictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("finlandpictureBox.ErrorImage")));
            this.finlandpictureBox.Image = global::Tutorial2_4.Properties.Resources.Finland;
            this.finlandpictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("finlandpictureBox.InitialImage")));
            this.finlandpictureBox.Location = new System.Drawing.Point(12, 102);
            this.finlandpictureBox.Name = "finlandpictureBox";
            this.finlandpictureBox.Size = new System.Drawing.Size(240, 146);
            this.finlandpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finlandpictureBox.TabIndex = 0;
            this.finlandpictureBox.TabStop = false;
            this.finlandpictureBox.WaitOnLoad = true;
            this.finlandpictureBox.Click += new System.EventHandler(this.finlandpictureBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.Location = new System.Drawing.Point(203, 299);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(377, 105);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "label1";
            this.countryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(233, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "點選一個國旗,我告訴你是哪個國家";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanpictureBox);
            this.Controls.Add(this.francepictureBox);
            this.Controls.Add(this.finlandpictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.germanpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox finlandpictureBox;
        private System.Windows.Forms.PictureBox francepictureBox;
        public System.Windows.Forms.PictureBox germanpictureBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label2;
    }
}

