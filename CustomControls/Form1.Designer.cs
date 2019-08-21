namespace CustomControls
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.textBoxExtend2 = new MyControls.TextBoxExtend(this.components);
            this.textBoxExtend1 = new MyControls.TextBoxExtend(this.components);
            this.verticalProcessBar1 = new MyControls.VerticalProcessBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(480, 309);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "向上";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(480, 369);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "向下";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPercent.Location = new System.Drawing.Point(493, 225);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 12);
            this.lblPercent.TabIndex = 5;
            // 
            // textBoxExtend2
            // 
            this.textBoxExtend2.Location = new System.Drawing.Point(264, 66);
            this.textBoxExtend2.Name = "textBoxExtend2";
            this.textBoxExtend2.Size = new System.Drawing.Size(100, 21);
            this.textBoxExtend2.TabIndex = 2;
            // 
            // textBoxExtend1
            // 
            this.textBoxExtend1.Location = new System.Drawing.Point(128, 66);
            this.textBoxExtend1.Name = "textBoxExtend1";
            this.textBoxExtend1.Size = new System.Drawing.Size(100, 21);
            this.textBoxExtend1.TabIndex = 0;
            // 
            // verticalProcessBar1
            // 
            this.verticalProcessBar1.BarHeight = 350;
            this.verticalProcessBar1.BarValue = 0D;
            this.verticalProcessBar1.BarWidth = 30;
            this.verticalProcessBar1.Location = new System.Drawing.Point(399, 21);
            this.verticalProcessBar1.Name = "verticalProcessBar1";
            this.verticalProcessBar1.Precent = null;
            this.verticalProcessBar1.Size = new System.Drawing.Size(30, 400);
            this.verticalProcessBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verticalProcessBar1);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.textBoxExtend2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxExtend1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.TextBoxExtend textBoxExtend1;
        private System.Windows.Forms.Button button1;
        private MyControls.TextBoxExtend textBoxExtend2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblPercent;
        private MyControls.VerticalProcessBar verticalProcessBar1;
    }
}

