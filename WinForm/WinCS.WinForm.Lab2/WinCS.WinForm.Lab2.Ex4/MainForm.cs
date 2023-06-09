using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCS.WinForm.Lab2.Ex4
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;

        public ParentForm()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows is cascade";
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows is horizontal";
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            SubForm newChild = new SubForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments;


        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void spWin_Click(object sender, EventArgs e)
        {
        }
    }
}