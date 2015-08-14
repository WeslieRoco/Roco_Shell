namespace RocoShellPE
{
    partial class frmDisk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.disks = new System.Windows.Forms.ListBox();
            this.disklistupd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dstatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dformat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtype = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dfull = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dfree = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newtype = new System.Windows.Forms.ComboBox();
            this.format = new System.Windows.Forms.Button();
            this.chkdsk = new System.Windows.Forms.Button();
            this.chkdskf = new System.Windows.Forms.Button();
            this.dcmd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分区列表";
            // 
            // disks
            // 
            this.disks.FormattingEnabled = true;
            this.disks.ItemHeight = 12;
            this.disks.Location = new System.Drawing.Point(15, 29);
            this.disks.Name = "disks";
            this.disks.Size = new System.Drawing.Size(157, 400);
            this.disks.TabIndex = 1;
            this.disks.SelectedIndexChanged += new System.EventHandler(this.disks_SelectedIndexChanged);
            // 
            // disklistupd
            // 
            this.disklistupd.Location = new System.Drawing.Point(15, 434);
            this.disklistupd.Name = "disklistupd";
            this.disklistupd.Size = new System.Drawing.Size(157, 23);
            this.disklistupd.TabIndex = 2;
            this.disklistupd.Text = "刷新";
            this.disklistupd.UseVisualStyleBackColor = true;
            this.disklistupd.Click += new System.EventHandler(this.disklistupd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "磁盘状态:";
            // 
            // dstatus
            // 
            this.dstatus.AutoSize = true;
            this.dstatus.Location = new System.Drawing.Point(273, 29);
            this.dstatus.Name = "dstatus";
            this.dstatus.Size = new System.Drawing.Size(0, 12);
            this.dstatus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "分区格式:";
            // 
            // dformat
            // 
            this.dformat.AutoSize = true;
            this.dformat.Location = new System.Drawing.Point(273, 52);
            this.dformat.Name = "dformat";
            this.dformat.Size = new System.Drawing.Size(0, 12);
            this.dformat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "磁盘格式:";
            // 
            // dtype
            // 
            this.dtype.AutoSize = true;
            this.dtype.Location = new System.Drawing.Point(273, 76);
            this.dtype.Name = "dtype";
            this.dtype.Size = new System.Drawing.Size(0, 12);
            this.dtype.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "磁盘卷标:";
            // 
            // dlabel
            // 
            this.dlabel.AutoSize = true;
            this.dlabel.Location = new System.Drawing.Point(273, 100);
            this.dlabel.Name = "dlabel";
            this.dlabel.Size = new System.Drawing.Size(0, 12);
            this.dlabel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "总空间:";
            // 
            // dfull
            // 
            this.dfull.AutoSize = true;
            this.dfull.Location = new System.Drawing.Point(273, 125);
            this.dfull.Name = "dfull";
            this.dfull.Size = new System.Drawing.Size(0, 12);
            this.dfull.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "可用空间:";
            // 
            // dfree
            // 
            this.dfree.AutoSize = true;
            this.dfree.Location = new System.Drawing.Point(273, 148);
            this.dfree.Name = "dfree";
            this.dfree.Size = new System.Drawing.Size(0, 12);
            this.dfree.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "格式化为";
            // 
            // newtype
            // 
            this.newtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newtype.FormattingEnabled = true;
            this.newtype.Location = new System.Drawing.Point(267, 170);
            this.newtype.Name = "newtype";
            this.newtype.Size = new System.Drawing.Size(177, 20);
            this.newtype.TabIndex = 6;
            // 
            // format
            // 
            this.format.Enabled = false;
            this.format.Location = new System.Drawing.Point(210, 201);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(234, 23);
            this.format.TabIndex = 7;
            this.format.Text = "抹掉分区";
            this.format.UseVisualStyleBackColor = true;
            this.format.Click += new System.EventHandler(this.format_Click);
            // 
            // chkdsk
            // 
            this.chkdsk.Location = new System.Drawing.Point(210, 230);
            this.chkdsk.Name = "chkdsk";
            this.chkdsk.Size = new System.Drawing.Size(234, 23);
            this.chkdsk.TabIndex = 7;
            this.chkdsk.Text = "验证分区";
            this.chkdsk.UseVisualStyleBackColor = true;
            this.chkdsk.Click += new System.EventHandler(this.chkdsk_Click);
            // 
            // chkdskf
            // 
            this.chkdskf.Location = new System.Drawing.Point(210, 259);
            this.chkdskf.Name = "chkdskf";
            this.chkdskf.Size = new System.Drawing.Size(234, 23);
            this.chkdskf.TabIndex = 7;
            this.chkdskf.Text = "修复分区";
            this.chkdskf.UseVisualStyleBackColor = true;
            this.chkdskf.Click += new System.EventHandler(this.chkdskf_Click);
            // 
            // dcmd
            // 
            this.dcmd.BackColor = System.Drawing.Color.White;
            this.dcmd.Location = new System.Drawing.Point(210, 289);
            this.dcmd.Multiline = true;
            this.dcmd.Name = "dcmd";
            this.dcmd.ReadOnly = true;
            this.dcmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dcmd.Size = new System.Drawing.Size(234, 168);
            this.dcmd.TabIndex = 8;
            this.dcmd.TextChanged += new System.EventHandler(this.dcmd_TextChanged);
            // 
            // frmDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 469);
            this.Controls.Add(this.dcmd);
            this.Controls.Add(this.chkdskf);
            this.Controls.Add(this.chkdsk);
            this.Controls.Add(this.format);
            this.Controls.Add(this.newtype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dfree);
            this.Controls.Add(this.dfull);
            this.Controls.Add(this.dlabel);
            this.Controls.Add(this.dtype);
            this.Controls.Add(this.dformat);
            this.Controls.Add(this.dstatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disklistupd);
            this.Controls.Add(this.disks);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDisk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Roco 磁盘助手";
            this.Load += new System.EventHandler(this.frmDisk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox disks;
        private System.Windows.Forms.Button disklistupd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dformat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dfull;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dfree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox newtype;
        private System.Windows.Forms.Button format;
        private System.Windows.Forms.Button chkdsk;
        private System.Windows.Forms.Button chkdskf;
        private System.Windows.Forms.TextBox dcmd;
    }
}