using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCS.WinForm.Lab1.Ex1
{
    public partial class TreyResearch : Form
    {
        public TreyResearch()
        {
            InitializeComponent();
        }

        private void borderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void resize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void opacit_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}