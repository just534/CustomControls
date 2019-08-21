using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls
{
    public partial class TextBoxExtend : TextBox
    {
        public TextBoxExtend()
        {
            InitializeComponent();
        }

        public TextBoxExtend(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #region 控件添加非空验证
        public int BeginCheckEmpty()
        {
            if (this.Text.Trim().Length == 0)
            {
                this.errorProvider.SetError(this, "必填项不能为空");
                return 0;
            }
            else
            {
                this.errorProvider.SetError(this, "");
                return 1;
            }
        }
        #endregion

        #region 正则表达式验证
        public int BeginCommonValidate(string regularExpress, string errorMsg)
        {
            if (this.BeginCheckEmpty() == 0) return 0;
            Regex regx = new Regex(regularExpress, RegexOptions.IgnoreCase);
            if (!regx.IsMatch(this.Text))
            {
                this.errorProvider.SetError(this, errorMsg);
                return 0;
            }
            else
            {
                this.errorProvider.SetError(this, string.Empty);
                return 1;
            }



        }
        #endregion

        #region 邮件地址验证
        public int BeginValidateEmail(string errorMsg)
        {
            return BeginCommonValidate(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", errorMsg);
        }

        #endregion

        #region 整数验证
        public int BeginValidateNumber(string errorMsg)
        {
            return BeginCommonValidate("^[0-9]*$", errorMsg);
        }
        #endregion

        #region 区间验证,验证某个范围内数据
        public int BeginValidateRange(string errorMsg, int min, int max)
        {
            //if (BeginCommonValidate(@"^[1-9]\d*|0$", errorMsg) == 0) return 0;
            if (min <= Convert.ToInt32(this.Text.Trim()) && Convert.ToInt32(this.Text.Trim()) <= max)
            {
                this.errorProvider.SetError(this, string.Empty);
                return 1;

            }
            else
            {
                this.errorProvider.SetError(this, errorMsg);
                return 0;
            }
        }
        #endregion


    }
}