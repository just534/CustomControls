using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls
{
    public partial class VerticalProcessBar : UserControl
    {
        public VerticalProcessBar()
        {
            InitializeComponent();
        }
        private double barValue=0;
        private int barHeight=350;
        private int barWidth=30;
        public string Precent { get; set; }
        public int BarHeight
        {
            get
            {
                return barHeight;
            }
            set
            {
                if(value<10 ||  value > 500)
                {
                    MessageBox.Show("长度不能小于10且不能大于800");
                    return;
                }
                else
                {
                    this.lblLong.Height = lblShort.Height = value;
                }
            }
        }

        public int BarWidth
        {
            get
            {
                return barWidth;
            }
            set
            {
                if (value < 10 || value >50)
                {
                    MessageBox.Show("长度不能小于10且不能大于200");
                    return;
                }
                else
                {
                    this.lblLong.Width = lblShort.Width = value;
                }
            }
        }

        public double BarValue
        {
            get
            {
                return barValue;
            }
            set
            {
                if (value > 100.00 || value < 0)
                {
                    //MessageBox.Show("取值 范围只能在0~100之间");
                    return;
                }
                else
                {
                    double percentvalue = value / 100 * barHeight;
                    this.lblShort.Height = this.lblLong.Height - Convert.ToInt32(percentvalue);
                    this.Precent = value.ToString() + "%";
                    this.barValue = value;
                }
            }
        }
    }
}
