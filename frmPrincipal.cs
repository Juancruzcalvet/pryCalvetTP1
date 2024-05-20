using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalvetTP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void quenakenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quenakenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLocalQuenaken frmLocalQuenaken = new frmLocalQuenaken();
            frmLocalQuenaken.Show();
        }
    }
}
