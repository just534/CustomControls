using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = this.textBoxExtend1.BeginCheckEmpty();
            int b = this.textBoxExtend1.BeginValidateRange("不能超过范围", 1, 30);
            int c= this.textBoxExtend2.BeginValidateRange("不能超过范围", 20, 30);
            int result = a * b;
            if (result == 1)
            {
                //编写提交代码
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            this.verticalProcessBar1.BarValue += 2;
            this.lblPercent.Text = this.verticalProcessBar1.Precent;
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            this.verticalProcessBar1.BarValue -= 2;
            this.lblPercent.Text = this.verticalProcessBar1.Precent;
        }
    }
}
