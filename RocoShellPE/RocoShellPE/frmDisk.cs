using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RocoShellPE
{
    public partial class frmDisk : Form
    {
        public frmDisk()
        {
            InitializeComponent();
        }

        private void frmDisk_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void disklistupd_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            disks.Items.Clear();
            DriveInfo[] ds = DriveInfo.GetDrives();
            foreach(DriveInfo d in ds)
            {
                disks.Items.Add("/media/Drive"+d.Name.Split(':')[0]);
            }
        }
        string disk = "";
        private void disks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disks.SelectedIndex > -1)
            {
                disk = disks.SelectedItem.ToString().Replace("/media/Drive","");
                RefreshDiskInfo(disk);
            }
        }
        private void RefreshDiskInfo(string diskdrive)
        {
            DriveInfo d = new DriveInfo(disk);
            dstatus.Text = d.IsReady ? "在线" : "离线";
            if (d.IsReady)
            {
                dformat.Text = d.DriveFormat;
                dtype.Text = DiskTypeConvert(d.DriveType);
                dfree.Text=ConvertSize(d.AvailableFreeSpace);
                dfull.Text = ConvertSize(d.TotalSize);
                dlabel.Text = d.VolumeLabel;
                format.Enabled = true;
                chkdsk.Enabled = true;
                chkdskf.Enabled = true;
                GetNewTypeItems(d.TotalSize);
            }
            else
            {
                dformat.Text = "";
                dtype.Text="";
                dfree.Text = "0 (0 Bytes)";
                dfull.Text = "0 (0 Bytes)";
                dlabel.Text = "";
                format.Enabled = false;
                chkdsk.Enabled = false;
                chkdskf.Enabled = false;
                newtype.Items.Clear();
            }
        }

        private void GetNewTypeItems(long size)
        {
            newtype.Items.Clear();
            if (size > G32)
            {
                newtype.Items.AddRange(new string[] { "NTFS", "exFAT" });
            }
            else if(size>M512)
            {
                newtype.Items.AddRange(new string[]{"FAT32","FAT","NTFS","exFAT"});
            }
            else
            {
                newtype.Items.AddRange(new string[] { "FAT", "FAT32" });
            }
            newtype.SelectedIndex = 0;
        }
        const double K = 1024, M = K * K, G = K * M, T = K * G,G32=32*G,M512=512*M;
        private string ConvertSize(long size)
        {            
            if(size>=T)
            {
                return size.ToString("0") + " (" + (size / T).ToString("0.00") + " TB)";
            }
            else if(size>=G)
            {
                return size.ToString("0") + " (" + (size / G).ToString("0.00") + " GB)";
            }
            else if(size>=M)
            {
                return size.ToString("0") + " (" + (size / M).ToString("0.00") + " MB)";
            }
            else if(size>=K)
            {
                return size.ToString("0") + " (" + (size / K).ToString("0.00") + " KB)";
            }
            else
            {
                return size.ToString("0") + " (" + (size).ToString("0.00") + " Bytes)";
            }
        }
        private string DiskTypeConvert(DriveType dt)
        {
            switch(dt)
            {
                case DriveType.CDRom: return "光盘";
                case DriveType.Fixed: return "硬盘";
                case DriveType.Network: return "网络驱动器";
                case DriveType.NoRootDirectory: return "没根目录的驱动器";
                case DriveType.Ram: return "RAM磁盘";
                case DriveType.Removable: return "可移动磁盘";
                case DriveType.Unknown: return "未知";
                default: return "非法磁盘";
            }
        }

        private void dcmd_TextChanged(object sender, EventArgs e)
        {
            if(dcmd.Text.Length>0)
            {
                dcmd.SelectionStart = dcmd.Text.Length - 1;
                dcmd.SelectionLength = 1;
                dcmd.ScrollToCaret();
            }
        }

        private void format_Click(object sender, EventArgs e)
        {
            //docmd("format.exe", disk + ": /Q /X /FS:" + newtype.SelectedItem.ToString());
            //ParameterizedThreadStart p=new ParameterizedThreadStart(docmd2);
            //p.BeginInvoke(new string[] {"format",disk + ": /Q /X /FS:" + newtype.SelectedItem.ToString()+" /V:"+disk }, null, null);
            //p.EndInvoke(i);
        }

        private void docmd2(object obj)
        {
            string[] s = (string[])obj;
            docmd(s[0], s[1]);
        }

        private void chkdsk_Click(object sender, EventArgs e)
        {
            //docmd("chkdsk.exe", disk + ":");
            ParameterizedThreadStart p = new ParameterizedThreadStart(docmd2);
            IAsyncResult i=p.BeginInvoke(new string[] { "chkdsk", disk + ":" }, null, null);
            //p.EndInvoke(i);
        }

        private void chkdskf_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart p = new ParameterizedThreadStart(docmd2);
            IAsyncResult i = p.BeginInvoke(new string[] { "chkdsk", disk + ": /R" }, null, null);
            //p.EndInvoke(i);
        }
        private void docmd(string cmd,string args)
        {
            dcmd.Text = "";
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c " + cmd + " " + args);
            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;
            Process p = new Process();
            p.StartInfo = psi;
            p.ErrorDataReceived += p_ErrorDataReceived;
            p.OutputDataReceived += p_OutputDataReceived;
            p.Start();
            p.BeginErrorReadLine();
            p.BeginOutputReadLine();
            p.WaitForExit();
            RefreshDiskInfo(disk);
        }

        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            AddText(e.Data);
        }

        private void AddText(string p)
        {
            if(dcmd.InvokeRequired)
            {
                dcmd.Invoke(new AddTextD(AddTextDT), p);
            }
            else
            {
                dcmd.Text += p+"\r\n";
            }
        }

        private void AddTextDT(string p)
        {
            dcmd.Text += p+"\r\n";
        }

        void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            AddText(e.Data);
        }
        delegate void AddTextD(string p);
    }
}
