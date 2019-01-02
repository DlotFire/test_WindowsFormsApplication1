using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_WindowsFormsApplication1
{
    public partial class Form_Str : Form
    {
        
        public Form_Str()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 返回主程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            HelpTools.MainForm.Show();
            this.Close();
        }

        /// <summary>
        /// 关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ke(object sender, KeyEventArgs e)
        {
            MsgTip.Items.Add(inputWord.Text);
        }
    }
}
