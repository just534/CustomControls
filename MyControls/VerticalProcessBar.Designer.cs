namespace MyControls
{
    partial class VerticalProcessBar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLong = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLong
            // 
            this.lblLong.BackColor = System.Drawing.Color.Blue;
            this.lblLong.Location = new System.Drawing.Point(0, 0);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(30, 350);
            this.lblLong.TabIndex = 0;
            // 
            // lblShort
            // 
            this.lblShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblShort.Location = new System.Drawing.Point(0, 0);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(30, 350);
            this.lblShort.TabIndex = 0;
            // 
            // VerticalProcessBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblLong);
            this.Name = "VerticalProcessBar";
            this.Size = new System.Drawing.Size(30, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblShort;
    }
}
