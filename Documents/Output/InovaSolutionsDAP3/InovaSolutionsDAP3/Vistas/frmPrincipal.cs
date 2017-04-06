using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InovaSolutionsDAP3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnu abri = new frmEnu();
            abri.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmEnu abri = new frmEnu();
            abri.ShowDialog();
        }
    }
}
