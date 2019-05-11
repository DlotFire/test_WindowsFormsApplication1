namespace test_WindowsFormsApplication1
{
    partial class Form_Str
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Exit_App = new System.Windows.Forms.Button();
            this.MsgTip = new System.Windows.Forms.ListBox();
            this.MsgTipTile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inputWord = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回主界面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_App
            // 
            this.Exit_App.Location = new System.Drawing.Point(242, 12);
            this.Exit_App.Name = "Exit_App";
            this.Exit_App.Size = new System.Drawing.Size(205, 41);
            this.Exit_App.TabIndex = 1;
            this.Exit_App.Text = "退出程序";
            this.Exit_App.UseVisualStyleBackColor = true;
            this.Exit_App.Click += new System.EventHandler(this.Exit_App_Click);
            // 
            // MsgTip
            // 
            this.MsgTip.FormattingEnabled = true;
            this.MsgTip.ItemHeight = 12;
            this.MsgTip.Location = new System.Drawing.Point(9, 577);
            this.MsgTip.Name = "MsgTip";
            this.MsgTip.Size = new System.Drawing.Size(435, 88);
            this.MsgTip.TabIndex = 2;
            // 
            // MsgTipTile
            // 
            this.MsgTipTile.AutoSize = true;
            this.MsgTipTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MsgTipTile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MsgTipTile.Location = new System.Drawing.Point(9, 553);
            this.MsgTipTile.Name = "MsgTipTile";
            this.MsgTipTile.Size = new System.Drawing.Size(88, 16);
            this.MsgTipTile.TabIndex = 3;
            this.MsgTipTile.Text = "提示信息：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputWord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 92);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文字：";
            // 
            // inputWord
            // 
            this.inputWord.Location = new System.Drawing.Point(5, 15);
            this.inputWord.Name = "inputWord";
            this.inputWord.Size = new System.Drawing.Size(185, 21);
            this.inputWord.TabIndex = 1;
            this.inputWord.Text = "请输入文字。。。。";
            // 
            // Form_Str
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MsgTipTile);
            this.Controls.Add(this.MsgTip);
            this.Controls.Add(this.Exit_App);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_Str";
            this.Text = "字符测试窗口";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit_App;
        private System.Windows.Forms.ListBox MsgTip;
        private System.Windows.Forms.Label MsgTipTile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputWord;
    }
}