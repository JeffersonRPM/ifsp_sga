using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSP_SGA
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade fcidade = new frmCidade();
            fcidade.MdiParent = this;
            fcidade.Show();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre fSobre = new frmSobre();
            fSobre.MdiParent = this;
            fSobre.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDisciplina fDisciplina = new frmDisciplina();
            fDisciplina.MdiParent = this;
            fDisciplina.Show();
        }
    }
}
