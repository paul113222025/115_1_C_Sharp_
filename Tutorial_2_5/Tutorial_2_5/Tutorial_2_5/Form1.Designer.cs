using System;

namespace Tutorial_2_5
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
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.showBackbutton = new System.Windows.Forms.Button();
            this.showFacebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = global::Tutorial_2_5.Properties.Resources.King_Hearts;
            this.cardFacePictureBox.Location = new System.Drawing.Point(344, 69);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(147, 229);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFacePictureBox.TabIndex = 1;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            this.cardFacePictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::Tutorial_2_5.Properties.Resources.Backface_Blue;
            this.cardBackPictureBox.Location = new System.Drawing.Point(344, 69);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(152, 229);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackPictureBox.TabIndex = 0;
            this.cardBackPictureBox.TabStop = false;
            this.cardBackPictureBox.Click += new System.EventHandler(this.cardBackPictureBox_Click);
            // 
            // showBackbutton
            // 
            this.showBackbutton.Location = new System.Drawing.Point(206, 328);
            this.showBackbutton.Name = "showBackbutton";
            this.showBackbutton.Size = new System.Drawing.Size(116, 75);
            this.showBackbutton.TabIndex = 2;
            this.showBackbutton.Text = "顯示背面";
            this.showBackbutton.UseVisualStyleBackColor = true;
            this.showBackbutton.UseWaitCursor = true;
            this.showBackbutton.Click += new System.EventHandler(this.showBackbutton_Click);
            // 
            // showFacebutton
            // 
            this.showFacebutton.Location = new System.Drawing.Point(508, 328);
            this.showFacebutton.Name = "showFacebutton";
            this.showFacebutton.Size = new System.Drawing.Size(116, 75);
            this.showFacebutton.TabIndex = 3;
            this.showFacebutton.Text = "顯示正面";
            this.showFacebutton.UseVisualStyleBackColor = true;
            this.showFacebutton.Click += new System.EventHandler(this.showFacebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showFacebutton);
            this.Controls.Add(this.showBackbutton);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
        private System.Windows.Forms.Button showBackbutton;
        private System.Windows.Forms.Button showFacebutton;
    }
}

