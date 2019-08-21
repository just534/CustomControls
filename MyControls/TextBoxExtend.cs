using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
    }
}
