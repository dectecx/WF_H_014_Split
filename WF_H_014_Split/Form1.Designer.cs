namespace WF_H_014_Split
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblOutputTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.plOutput = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plOutput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtInput.Location = new System.Drawing.Point(378, 34);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(379, 29);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblInputTitle.Location = new System.Drawing.Point(374, 9);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(73, 20);
            this.lblInputTitle.TabIndex = 1;
            this.lblInputTitle.Text = "輸入字串";
            // 
            // lblOutputTitle
            // 
            this.lblOutputTitle.AutoSize = true;
            this.lblOutputTitle.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblOutputTitle.Location = new System.Drawing.Point(374, 66);
            this.lblOutputTitle.Name = "lblOutputTitle";
            this.lblOutputTitle.Size = new System.Drawing.Size(73, 20);
            this.lblOutputTitle.TabIndex = 2;
            this.lblOutputTitle.Text = "輸出結果";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblDesc.Location = new System.Drawing.Point(12, 9);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(41, 20);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "說明";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 220);
            this.label1.TabIndex = 6;
            this.label1.Text = "輸入一連串字母與特殊符號(空格/逗點/句點)\r\n所組成的字串，將字串分割成個別的字母，並\r\n統計每一字母出現的次數\r\n\r\n輸入範例：a, a, a, b , , " +
    ".b c. a. a,d,d a c, b, b   c\r\n\r\n輸出結果：\r\na: 6\r\nb: 4\r\nc: 3\r\nd: 2";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblOutput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOutput.Location = new System.Drawing.Point(3, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 20);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "none";
            // 
            // plOutput
            // 
            this.plOutput.AutoScroll = true;
            this.plOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plOutput.Controls.Add(this.lblOutput);
            this.plOutput.Location = new System.Drawing.Point(378, 89);
            this.plOutput.Name = "plOutput";
            this.plOutput.Size = new System.Drawing.Size(379, 359);
            this.plOutput.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 416);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(769, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plOutput);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblOutputTitle);
            this.Controls.Add(this.lblInputTitle);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Split練習題";
            this.plOutput.ResumeLayout(false);
            this.plOutput.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblOutputTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel plOutput;
        private System.Windows.Forms.Panel panel1;
    }
}

