namespace WindowsFormsApp1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiFlowLayoutPanel1 = new Sunny.UI.UIFlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.管理编号 = new System.Windows.Forms.Label();
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.uiFlowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(193, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 862);
            this.panel2.TabIndex = 4;
            // 
            // uiFlowLayoutPanel1
            // 
            this.uiFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlowLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiFlowLayoutPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiFlowLayoutPanel1.Name = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.uiFlowLayoutPanel1.ShowText = false;
            this.uiFlowLayoutPanel1.Size = new System.Drawing.Size(1182, 862);
            this.uiFlowLayoutPanel1.TabIndex = 0;
            this.uiFlowLayoutPanel1.Text = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.管理编号);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 91);
            this.panel1.TabIndex = 3;
            // 
            // 管理编号
            // 
            this.管理编号.AutoSize = true;
            this.管理编号.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.管理编号.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.管理编号.Location = new System.Drawing.Point(206, 51);
            this.管理编号.Name = "管理编号";
            this.管理编号.Size = new System.Drawing.Size(0, 25);
            this.管理编号.TabIndex = 2;
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(0, 126);
            this.uiNavMenu1.Name = "uiNavMenu1";
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(193, 862);
            this.uiNavMenu1.TabIndex = 2;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1375, 988);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uiNavMenu1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 960, 593);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIFlowLayoutPanel uiFlowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label 管理编号;
        private Sunny.UI.UINavMenu uiNavMenu1;
    }
}

