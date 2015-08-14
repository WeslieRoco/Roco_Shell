using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RocoShellPE
{
    public partial class frmProtect : Form
    {
        public frmProtect()
        {
            InitializeComponent();
        }

        private void frmProtect_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            mainpanel.Location = new Point((w - mainpanel.Width) / 2, (h - mainpanel.Height) / 2);
            version.Location = new Point((w - version.Width) / 2, h - version.Height-20);
            Question = Question.Init();
            question.Text = Question.question;
            A.Text = "A: "+Question.A;
            B.Text = "B: " + Question.B;
            C.Text = "C: " + Question.C;
            D.Text = "D: " + Question.D;
        }

        private void A_Click(object sender, EventArgs e)
        {
            Answer("A");
        }

        private void B_Click(object sender, EventArgs e)
        {
            Answer("B");
        }

        private void C_Click(object sender, EventArgs e)
        {
            Answer("C");
        }

        private void D_Click(object sender, EventArgs e)
        {
            Answer("D");
        }

        Question Question;

        void Answer(string answer)
        {
            if (answer == Question.answer)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("PE保护问题回答错误，PE将会重启", this.Text);
                Application.Exit();
            }
        }
    }
}
