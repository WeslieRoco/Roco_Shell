using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RocoShell
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");
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

        private void 关机SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wpeutil.exe", "shutdown");
        }

        private void 重启RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wpeutil.exe", "reboot");
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            XDocument xd = XDocument.Load("program.xml");
            IEnumerable<XElement> xes = xd.Root.Elements("program");
            foreach(XElement xe in xes)
            {
                InitIcons(xe.Element("name").Value, xe.Element("path").Value, xe.Element("icon").Value,
                    int.Parse(xe.Element("index").Value));
            }
        }

        private void InitIcons(string text,string filename,string iconname,int index)
        {
            ListViewItem lvi = listView1.Items.Add(text);
            lvi.Tag = new FileInfo(filename).FullName;
            string ext = new FileInfo(filename).Extension;
            //MessageBox.Show(ext);
            Image ico = InitExtIcon(ext, iconname,index);
            if (ico != null && imageList2.Images.Keys.IndexOf(ext.ToLower() != ".exe" ? ext.Substring(1) : (iconname + "_" + index.ToString())) == -1)
            {
                imageList2.Images.Add(ext.ToLower() != ".exe" ? ext.Substring(1) : (iconname+"_"+index.ToString()), ico);
            }
            if (ext == "" || imageList2.Images.Keys.IndexOf(ext.ToLower() != ".exe" ? ext.Substring(1) : (iconname + "_" + index.ToString())) == -1)
            {
                lvi.ImageKey = "file";
            }
            else
            {
                lvi.ImageKey = ext.ToLower() != ".exe" ? ext.Substring(1) : (iconname + "_" + index.ToString());
            }
            listView1.DoubleClick += listView1_DoubleClick;
        }

        void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (itemindex > -1)
            {
                Process.Start(listView1.Items[itemindex].Tag.ToString(), "");
                itemindex = -1;
                listView1.SelectedIndices.Clear();
            }
        }

        void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(listView1.Items[itemindex].Tag.ToString(), "");
        }

        [DllImport("shell32.dll")]
        public static extern IntPtr ExtractIconEx(string lpszFile, int nIconIndex, ref IntPtr phiconLarge, ref IntPtr phiconSmall, uint nIcons);

        public Image InitExtIcon(string ext, string filename,int Index)
        {
            Image exticon;
            try
            {
                if (ext.ToLower() != ".exe")
                {
                    string Type = Registry.GetValue("HKEY_CLASSES_ROOT\\" + ext, "", "").ToString();
                    string TypeName = Registry.GetValue("HKEY_CLASSES_ROOT\\" + Type, "", "").ToString();
                    string Icon = Registry.GetValue("HKEY_CLASSES_ROOT\\" + Type + "\\DefaultIcon", "", "").ToString();
                    if (Icon != "")
                    {
                        string[] tmp = Icon.Split(',');
                        int index;
                        if (tmp.Length == 2)
                        {
                            index = int.Parse(tmp[1]);
                            System.IntPtr phiconLarge = new IntPtr();
                            System.IntPtr phiconSmall = new IntPtr();
                            IntPtr handle = ExtractIconEx(tmp[0].Trim('"'), index, ref phiconLarge, ref phiconSmall, 1);
                            Icon ico = System.Drawing.Icon.FromHandle(phiconLarge);
                            //pictureBox1.Image = ico.ToBitmap();
                            //label1.Text = TypeName;
                            exticon = ico.ToBitmap();
                        }
                        else
                        {
                            index = 0;
                            System.IntPtr phiconLarge = new IntPtr();
                            System.IntPtr phiconSmall = new IntPtr();
                            IntPtr handle = ExtractIconEx(tmp[0].Trim('"'), index, ref phiconLarge, ref phiconSmall, 1);
                            Icon ico = System.Drawing.Icon.FromHandle(phiconLarge);
                            //pictureBox1.Image = ico.ToBitmap();
                            //label1.Text = TypeName;
                            exticon = ico.ToBitmap();
                        }
                    }
                    else
                    {
                        exticon = null;
                    }
                }
                else
                {
                    int index = 0;
                    index = Index;
                    System.IntPtr phiconLarge = new IntPtr();
                    System.IntPtr phiconSmall = new IntPtr();
                    IntPtr handle = ExtractIconEx(filename, index, ref phiconLarge, ref phiconSmall, 1);
                    Icon ico = System.Drawing.Icon.FromHandle(phiconLarge);
                    //pictureBox1.Image = ico.ToBitmap();
                    //label1.Text = TypeName;
                    exticon = ico.ToBitmap();
                }
            }
            catch
            {
                exticon = null;
            }
            return exticon;
        }

        int itemindex = -1;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                itemindex = listView1.SelectedIndices[0];
            }
        }
    }
}
