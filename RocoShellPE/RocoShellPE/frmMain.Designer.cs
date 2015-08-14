namespace RocoShellPE
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.电源PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关机SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.命令行提示符CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerShellSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winRARRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分区工具DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于PEAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.RocoDiskShell = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 电源PToolStripMenuItem
            // 
            this.电源PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重启RToolStripMenuItem,
            this.关机SToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.电源PToolStripMenuItem.Name = "电源PToolStripMenuItem";
            this.电源PToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.电源PToolStripMenuItem.Text = "电源(&P)";
            // 
            // 重启RToolStripMenuItem
            // 
            this.重启RToolStripMenuItem.Name = "重启RToolStripMenuItem";
            this.重启RToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.重启RToolStripMenuItem.Text = "重启(&R)";
            this.重启RToolStripMenuItem.Click += new System.EventHandler(this.重启RToolStripMenuItem_Click);
            // 
            // 关机SToolStripMenuItem
            // 
            this.关机SToolStripMenuItem.Name = "关机SToolStripMenuItem";
            this.关机SToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关机SToolStripMenuItem.Text = "关机(&S)";
            this.关机SToolStripMenuItem.Click += new System.EventHandler(this.关机SToolStripMenuItem_Click);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 命令行提示符CToolStripMenuItem
            // 
            this.命令行提示符CToolStripMenuItem.Name = "命令行提示符CToolStripMenuItem";
            this.命令行提示符CToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.命令行提示符CToolStripMenuItem.Text = "命令行提示符(&C)";
            this.命令行提示符CToolStripMenuItem.Click += new System.EventHandler(this.命令行提示符CToolStripMenuItem_Click);
            // 
            // powerShellSToolStripMenuItem
            // 
            this.powerShellSToolStripMenuItem.Name = "powerShellSToolStripMenuItem";
            this.powerShellSToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.powerShellSToolStripMenuItem.Text = "PowerShell(&S)";
            this.powerShellSToolStripMenuItem.Click += new System.EventHandler(this.powerShellSToolStripMenuItem_Click);
            // 
            // winRARRToolStripMenuItem
            // 
            this.winRARRToolStripMenuItem.Name = "winRARRToolStripMenuItem";
            this.winRARRToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.winRARRToolStripMenuItem.Text = "WinRAR(&R)";
            this.winRARRToolStripMenuItem.Click += new System.EventHandler(this.winRARRToolStripMenuItem_Click);
            // 
            // zipZToolStripMenuItem
            // 
            this.zipZToolStripMenuItem.Name = "zipZToolStripMenuItem";
            this.zipZToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.zipZToolStripMenuItem.Text = "7-Zip(&Z)";
            this.zipZToolStripMenuItem.Click += new System.EventHandler(this.zipZToolStripMenuItem_Click);
            // 
            // 记事本NToolStripMenuItem
            // 
            this.记事本NToolStripMenuItem.Name = "记事本NToolStripMenuItem";
            this.记事本NToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.记事本NToolStripMenuItem.Text = "记事本(&N)";
            this.记事本NToolStripMenuItem.Click += new System.EventHandler(this.记事本NToolStripMenuItem_Click);
            // 
            // 分区工具DToolStripMenuItem
            // 
            this.分区工具DToolStripMenuItem.Name = "分区工具DToolStripMenuItem";
            this.分区工具DToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.分区工具DToolStripMenuItem.Text = "分区工具(&D)";
            this.分区工具DToolStripMenuItem.Click += new System.EventHandler(this.分区工具DToolStripMenuItem_Click);
            // 
            // 关于PEAToolStripMenuItem
            // 
            this.关于PEAToolStripMenuItem.Name = "关于PEAToolStripMenuItem";
            this.关于PEAToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.关于PEAToolStripMenuItem.Text = "关于PE(&A)";
            this.关于PEAToolStripMenuItem.Click += new System.EventHandler(this.关于PEAToolStripMenuItem_Click);
            // 
            // Time
            // 
            this.Time.Enabled = false;
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(44, 21);
            this.Time.Text = "时间";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电源PToolStripMenuItem,
            this.命令行提示符CToolStripMenuItem,
            this.powerShellSToolStripMenuItem,
            this.winRARRToolStripMenuItem,
            this.zipZToolStripMenuItem,
            this.记事本NToolStripMenuItem,
            this.分区工具DToolStripMenuItem,
            this.RocoDiskShell,
            this.关于PEAToolStripMenuItem,
            this.Time});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(786, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // TimeUpdate
            // 
            this.TimeUpdate.Enabled = true;
            this.TimeUpdate.Interval = 1000;
            this.TimeUpdate.Tick += new System.EventHandler(this.TimeUpdate_Tick);
            // 
            // RocoDiskShell
            // 
            this.RocoDiskShell.Name = "RocoDiskShell";
            this.RocoDiskShell.Size = new System.Drawing.Size(119, 21);
            this.RocoDiskShell.Text = "Roco 磁盘助手(&U)";
            this.RocoDiskShell.Click += new System.EventHandler(this.RocoDiskShell_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 537);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roco PE Shell";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 电源PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关机SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 命令行提示符CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerShellSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winRARRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记事本NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分区工具DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于PEAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer TimeUpdate;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RocoDiskShell;
    }
}

