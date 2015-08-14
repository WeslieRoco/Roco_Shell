using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RocoShellPE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmProtect p = new frmProtect();
            p.ShowDialog();
        }

        private void TimeUpdate_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");
        }

        private void 分区工具DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("diskpart.exe", "");
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (Environment.GetEnvironmentVariable("systemdrive") == "X:")
            {
                Process.Start("startnet.cmd", "");
            }
            else
            {
                MessageBox.Show("Roco PE Shell 不在 PE 环境下运行", "Roco PE Shell", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 重启RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wpeutil.exe","reboot");
        }

        private void 关机SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wpeutil.exe", "shutdown");
        }

        private void 命令行提示符CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "");
        }

        private void powerShellSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("powershell.exe", "");
        }

        private void 记事本NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "");
        }

        private void winRARRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("WinRAR.exe", "");
        }

        private void zipZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("7zFM.exe", "");
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于PEAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
        frmDisk disk = null;
        private void RocoDiskShell_Click(object sender, EventArgs e)
        {
            if (disk == null||disk.IsDisposed)
            {
                disk = new frmDisk();
                disk.Show();
            }
            else
            {
                disk.BringToFront();
            }
        }
    }
}
