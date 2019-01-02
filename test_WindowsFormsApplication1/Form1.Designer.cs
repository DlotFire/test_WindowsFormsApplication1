namespace test_WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_Str = new System.Windows.Forms.Button();
            this.selectDiction = new System.Windows.Forms.Button();
            this.richTextBox_tip = new System.Windows.Forms.RichTextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Btn_Str
            // 
            this.Btn_Str.Location = new System.Drawing.Point(32, 34);
            this.Btn_Str.Name = "Btn_Str";
            this.Btn_Str.Size = new System.Drawing.Size(161, 33);
            this.Btn_Str.TabIndex = 3;
            this.Btn_Str.Text = "字符窗口";
            this.Btn_Str.UseVisualStyleBackColor = true;
            this.Btn_Str.Click += new System.EventHandler(this.Btn_Str_Click);
            // 
            // selectDiction
            // 
            this.selectDiction.Location = new System.Drawing.Point(32, 73);
            this.selectDiction.Name = "selectDiction";
            this.selectDiction.Size = new System.Drawing.Size(161, 38);
            this.selectDiction.TabIndex = 4;
            this.selectDiction.Text = "选择目录";
            this.selectDiction.UseVisualStyleBackColor = true;
            this.selectDiction.Click += new System.EventHandler(this.selectDiction_Click);
            // 
            // richTextBox_tip
            // 
            this.richTextBox_tip.Location = new System.Drawing.Point(218, 34);
            this.richTextBox_tip.Name = "richTextBox_tip";
            this.richTextBox_tip.Size = new System.Drawing.Size(277, 179);
            this.richTextBox_tip.TabIndex = 5;
            this.richTextBox_tip.Text = "";
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(32, 186);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(161, 27);
            this.btn_input.TabIndex = 6;
            this.btn_input.Text = "输入";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_input.Location = new System.Drawing.Point(30, 159);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(163, 21);
            this.textBox_input.TabIndex = 7;
            this.textBox_input.Text = "请输入....";
            this.textBox_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 465);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.richTextBox_tip);
            this.Controls.Add(this.selectDiction);
            this.Controls.Add(this.Btn_Str);
            this.Name = "Form1";
            this.Text = "fan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Str;
        private System.Windows.Forms.Button selectDiction;
        private System.Windows.Forms.RichTextBox richTextBox_tip;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Timer timer1;
    }
}

