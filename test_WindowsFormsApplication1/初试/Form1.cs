using System;
using System.Windows.Forms;

namespace test_WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int timeTick = 0;

        public Form1()
        {
            InitializeComponent();
            //timer1.Start();
        }

        /// <summary>
        /// 开启字符窗口的按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Str_Click(object sender, EventArgs e)
        {
            Form_Str fomStr = new Form_Str();
            fomStr.Show();
            this.Hide();
        }

        /// <summary>
        /// 选择目录的按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectDiction_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            path.ShowDialog();
            MessageBox.Show(path.FileName);
        }

        /// <summary>
        /// 用户输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_input_Click(object sender, EventArgs e)
        {
            richTextBox_tip.AppendText(textBox_input.Text);
            richTextBox_tip.AppendText("\n");
            richTextBox_tip.AppendText(timer1.Interval.ToString());
            richTextBox_tip.AppendText("\n");
        }

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwflags);
        
        /// <summary>
        /// 时间类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Close();
            mouse_event(0x0002 | 0x0004);
        }
    }
}
