namespace RocoShellPE
{
    partial class frmProtect
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainpanel.Controls.Add(this.D);
            this.mainpanel.Controls.Add(this.C);
            this.mainpanel.Controls.Add(this.B);
            this.mainpanel.Controls.Add(this.A);
            this.mainpanel.Controls.Add(this.question);
            this.mainpanel.Location = new System.Drawing.Point(3, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(888, 543);
            this.mainpanel.TabIndex = 0;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.question.Location = new System.Drawing.Point(31, 18);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(305, 46);
            this.question.TabIndex = 0;
            this.question.Text = "这里是PE保护问题";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A.Location = new System.Drawing.Point(31, 209);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(305, 46);
            this.A.TabIndex = 1;
            this.A.Text = "这里是PE保护问题";
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B.Location = new System.Drawing.Point(31, 276);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(305, 46);
            this.B.TabIndex = 2;
            this.B.Text = "这里是PE保护问题";
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.C.Location = new System.Drawing.Point(31, 357);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(305, 46);
            this.C.TabIndex = 3;
            this.C.Text = "这里是PE保护问题";
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.D.Location = new System.Drawing.Point(31, 431);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(305, 46);
            this.D.TabIndex = 4;
            this.D.Text = "这里是PE保护问题";
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.version.Location = new System.Drawing.Point(243, 572);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(515, 46);
            this.version.TabIndex = 5;
            this.version.Text = "Roco PE 2.0 Love Live! Edition";
            // 
            // frmProtect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 640);
            this.ControlBox = false;
            this.Controls.Add(this.version);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProtect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roco PE 保护模块";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProtect_Load);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label version;
    }
}