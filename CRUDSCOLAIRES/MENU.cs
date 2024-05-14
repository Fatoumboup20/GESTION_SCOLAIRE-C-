using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSCOLAIRES
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void gESTIONCLASSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse claase = new FormClasse();
            claase.Show();
        }

        private void gESTIONETUDIANTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtudiant etudiant = new FormEtudiant();
            etudiant.Show();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
