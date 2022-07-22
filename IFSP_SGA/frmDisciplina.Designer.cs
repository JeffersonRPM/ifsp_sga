
namespace IFSP_SGA
{
    partial class frmDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisciplina));
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.barDisciplina = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.chkTeorica = new System.Windows.Forms.CheckBox();
            this.chkPratica = new System.Windows.Forms.CheckBox();
            this.chkObrigatoria = new System.Windows.Forms.CheckBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblPreRequisitos = new System.Windows.Forms.Label();
            this.txtPreRequisitos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.barDisciplina.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(13, 64);
            this.grdDados.Margin = new System.Windows.Forms.Padding(4);
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.Size = new System.Drawing.Size(298, 450);
            this.grdDados.TabIndex = 3;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            this.grdDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellContentClick);
            // 
            // barDisciplina
            // 
            this.barDisciplina.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.barDisciplina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnAlterar,
            this.btnExcluir,
            this.btnSalvar,
            this.btnCancelar,
            this.btnSair});
            this.barDisciplina.Location = new System.Drawing.Point(0, 0);
            this.barDisciplina.Name = "barDisciplina";
            this.barDisciplina.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.barDisciplina.Size = new System.Drawing.Size(682, 55);
            this.barDisciplina.TabIndex = 2;
            this.barDisciplina.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(52, 52);
            this.btnNovo.Text = "toolStripButton1";
            this.btnNovo.ToolTipText = "Cadastra uma nova Disciplina";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(52, 52);
            this.btnAlterar.Text = "toolStripButton2";
            this.btnAlterar.ToolTipText = "Edita a Disciplina secionada";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(52, 52);
            this.btnExcluir.Text = "toolStripButton3";
            this.btnExcluir.ToolTipText = "Exclui a Disciplina selecionada";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 52);
            this.btnSalvar.Text = "toolStripButton4";
            this.btnSalvar.ToolTipText = "Salva os dados da Disciplina";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 52);
            this.btnCancelar.Text = "toolStripButton5";
            this.btnCancelar.ToolTipText = "Cancela a inclusão/edição";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 52);
            this.btnSair.Text = "toolStripButton6";
            this.btnSair.ToolTipText = "Finaliza a manutenção da Disciplina";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(319, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(323, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 26);
            this.txtNome.TabIndex = 5;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigla.Location = new System.Drawing.Point(319, 115);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(44, 20);
            this.lblSigla.TabIndex = 6;
            this.lblSigla.Text = "Sigla";
            this.lblSigla.Click += new System.EventHandler(this.lblSigla_Click);
            // 
            // txtSigla
            // 
            this.txtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(323, 138);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(70, 26);
            this.txtSigla.TabIndex = 7;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.Location = new System.Drawing.Point(405, 115);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(105, 20);
            this.lblCargaHoraria.TabIndex = 8;
            this.lblCargaHoraria.Text = "Carga horária";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargaHoraria.Location = new System.Drawing.Point(409, 139);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(100, 26);
            this.txtCargaHoraria.TabIndex = 9;
            // 
            // chkTeorica
            // 
            this.chkTeorica.AutoSize = true;
            this.chkTeorica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTeorica.Location = new System.Drawing.Point(323, 170);
            this.chkTeorica.Name = "chkTeorica";
            this.chkTeorica.Size = new System.Drawing.Size(80, 24);
            this.chkTeorica.TabIndex = 10;
            this.chkTeorica.Text = "Teórica";
            this.chkTeorica.UseVisualStyleBackColor = true;
            // 
            // chkPratica
            // 
            this.chkPratica.AutoSize = true;
            this.chkPratica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPratica.Location = new System.Drawing.Point(409, 170);
            this.chkPratica.Name = "chkPratica";
            this.chkPratica.Size = new System.Drawing.Size(77, 24);
            this.chkPratica.TabIndex = 11;
            this.chkPratica.Text = "Prática";
            this.chkPratica.UseVisualStyleBackColor = true;
            // 
            // chkObrigatoria
            // 
            this.chkObrigatoria.AutoSize = true;
            this.chkObrigatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkObrigatoria.Location = new System.Drawing.Point(492, 170);
            this.chkObrigatoria.Name = "chkObrigatoria";
            this.chkObrigatoria.Size = new System.Drawing.Size(106, 24);
            this.chkObrigatoria.TabIndex = 12;
            this.chkObrigatoria.Text = "Obrigatória";
            this.chkObrigatoria.UseVisualStyleBackColor = true;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(520, 115);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(78, 20);
            this.lblSemestre.TabIndex = 13;
            this.lblSemestre.Text = "Semestre";
            // 
            // cboSemestre
            // 
            this.cboSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "1º Semestre",
            "2º Semestre",
            "3º Semestre",
            "4º Semestre",
            "5º Semestre",
            "6º Semestre",
            "7º Semestre",
            "8º Semestre",
            "9º Semestre",
            "10º Semestre"});
            this.cboSemestre.Location = new System.Drawing.Point(524, 137);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(121, 28);
            this.cboSemestre.TabIndex = 14;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(318, 197);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(323, 220);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(347, 145);
            this.txtDescricao.TabIndex = 16;
            // 
            // lblPreRequisitos
            // 
            this.lblPreRequisitos.AutoSize = true;
            this.lblPreRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreRequisitos.Location = new System.Drawing.Point(319, 368);
            this.lblPreRequisitos.Name = "lblPreRequisitos";
            this.lblPreRequisitos.Size = new System.Drawing.Size(113, 20);
            this.lblPreRequisitos.TabIndex = 17;
            this.lblPreRequisitos.Text = "Pré-Requisitos";
            // 
            // txtPreRequisitos
            // 
            this.txtPreRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreRequisitos.Location = new System.Drawing.Point(322, 391);
            this.txtPreRequisitos.Multiline = true;
            this.txtPreRequisitos.Name = "txtPreRequisitos";
            this.txtPreRequisitos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreRequisitos.Size = new System.Drawing.Size(347, 116);
            this.txtPreRequisitos.TabIndex = 18;
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 519);
            this.Controls.Add(this.txtPreRequisitos);
            this.Controls.Add(this.lblPreRequisitos);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cboSemestre);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.chkObrigatoria);
            this.Controls.Add(this.chkPratica);
            this.Controls.Add(this.chkTeorica);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.grdDados);
            this.Controls.Add(this.barDisciplina);
            this.Name = "frmDisciplina";
            this.Text = "Manutenção de Disciplinas";
            this.Load += new System.EventHandler(this.frmDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.barDisciplina.ResumeLayout(false);
            this.barDisciplina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.ToolStrip barDisciplina;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.CheckBox chkTeorica;
        private System.Windows.Forms.CheckBox chkPratica;
        private System.Windows.Forms.CheckBox chkObrigatoria;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblPreRequisitos;
        private System.Windows.Forms.TextBox txtPreRequisitos;
    }
}