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
    public partial class frmDisciplina : Form
    {
        csDisciplina disc = new csDisciplina();

        private void habilitaControles(bool status)
        {
            txtNome.Enabled = status;
            txtSigla.Enabled = status;
            txtCargaHoraria.Enabled = status;
            txtDescricao.Enabled = status;
            txtPreRequisitos.Enabled = status;
            chkObrigatoria.Enabled = status;
            chkPratica.Enabled = status;
            chkTeorica.Enabled = status;
            cboSemestre.Enabled = status;
        }

        private void limparControles()
        {
            disc.setDiscId(0);
            txtNome.Text = "";
            txtSigla.Text = "";
            txtCargaHoraria.Text = "";
            txtDescricao.Text = "";
            txtPreRequisitos.Text = "";
            cboSemestre.SelectedIndex = -1;
            chkObrigatoria.CheckState = CheckState.Unchecked;
            chkPratica.CheckState = CheckState.Unchecked;
            chkTeorica.CheckState = CheckState.Unchecked;

        }

        private void gerenciaBotoesBarra(bool status)
        {
            btnNovo.Enabled = status;
            btnAlterar.Enabled = status;
            btnExcluir.Enabled = status;
            btnSair.Enabled = status;
            btnSalvar.Enabled = !status;
            btnCancelar.Enabled = !status;

        }

        private void formataGrid()
        {
            grdDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDados.Columns[0].HeaderText = "Código";
            grdDados.Columns[1].HeaderText = "Sigla";
            grdDados.Columns[2].HeaderText = "Nome";

            grdDados.Columns[0].Width = 0;
            grdDados.Columns[1].Width = 70;
            grdDados.Columns[2].Width = 260;
        }

        private void excluiDisciplina()
        {
            disc.delete();
        }
        
        private void salvarDisciplina()
        {
            disc.SetDiscNome(txtNome.Text);
            disc.setDiscSigla(txtSigla.Text);
            disc.setDiscCargaHoraria(Convert.ToInt32(txtCargaHoraria.Text));
            disc.setDiscDescricao(txtDescricao.Text);
            disc.setDiscPreRequisito(txtPreRequisitos.Text);
            disc.setDiscTeorica(chkTeorica.Checked);
            disc.setDiscPratica(chkPratica.Checked);
            disc.setDiscObrigatoria(chkObrigatoria.Checked);
            disc.setDiscSemestre(cboSemestre.SelectedIndex);


            if (disc.getDiscId() == 0 )
            {
                disc.inserir();
            }

            else
            {
                disc.update();    
            }
        }

        private void preencheGrid()
        {
            grdDados.DataSource = disc.select();
            formataGrid();
        }

        private void preencheDadosControles()
        {
            disc.selecDisciplina();

            txtNome.Text = disc.getDiscNome();
            txtSigla.Text = disc.getDiscSigla();
            txtCargaHoraria.Text = disc.getDiscCargaHoraria().ToString();
            txtDescricao.Text = disc.getDiscDescricao();
            txtPreRequisitos.Text = disc.getDiscPreRequisito();
            chkTeorica.Checked = disc.getDiscTeorica();
            chkPratica.Checked = disc.getDiscDiscpratica();
            chkObrigatoria.Checked = disc.getDiscObrigatoria();
            cboSemestre.SelectedIndex = disc.getDiscSemestre();
        }

        private bool validaDados()
        {
            if(txtNome.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Nome da disciplina é obrigatório!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }
            if (txtSigla.Text.Trim().Length <= 3)
            {
                MessageBox.Show("Sigla da disciplina é obrigatória!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSigla.Focus();
                return false;
            }
            return true;
        }

        public frmDisciplina()
        {
            InitializeComponent();
        }

        private void lblSigla_Click(object sender, EventArgs e)
        {

        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {
            habilitaControles(false);
            gerenciaBotoesBarra(true);
            preencheGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            gerenciaBotoesBarra(false);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            gerenciaBotoesBarra(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (disc.getDiscId() != 0)
            {
                //opcao 1 - estrutura de decisão "if"
                DialogResult retorno = MessageBox.Show("Deseja excluir a disciplina selecionada?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retorno == DialogResult.Yes)
                {
                    excluiDisciplina();
                    limparControles();
                    preencheGrid();
                }
            }

            else
            {
                MessageBox.Show("Selecione a disciplina para excluir!!", "Aviso!!", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }


            //switch (retorno)
            //{
            //    case DialogResult.Yes:
            //        limparControles();
            //        break;
            //    case DialogResult.No:
            //        break;
            //    default:
            //        break;
            //}

            //opcao2 - retorno messagebox
            //if (MessageBox.Show("Deseja excluir a disciplina selecionada?", "Exclusão",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //limparControles();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(validaDados() == true)
            {
                salvarDisciplina();
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
                preencheGrid();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja cancelar a manutenção da disciplina?", "Aviso!!!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disc.setDiscId(Convert.ToInt32(grdDados.Rows[grdDados.CurrentRow.Index].Cells[0].Value.ToString()));
            preencheDadosControles();
        }
    }
}
