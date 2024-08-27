namespace filmesApp2A
{
    partial class frmEditarFilmes
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
            components = new System.ComponentModel.Container();
            btSalvar = new Button();
            dgvAtores = new DataGridView();
            cbxPais = new ComboBox();
            txtNome = new TextBox();
            lblAtores = new Label();
            lblNacionalidade = new Label();
            lblNome = new Label();
            lblAnoLancamento = new Label();
            numAnoLancamento = new NumericUpDown();
            atorBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(235, 188);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 13;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAtores.DataSource = atorBindingSource;
            dgvAtores.Location = new Point(42, 256);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(491, 216);
            dgvAtores.TabIndex = 12;
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(235, 75);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(197, 23);
            cbxPais.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(235, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 10;
            // 
            // lblAtores
            // 
            lblAtores.AutoSize = true;
            lblAtores.Location = new Point(42, 227);
            lblAtores.Name = "lblAtores";
            lblAtores.Size = new Size(44, 15);
            lblAtores.TabIndex = 9;
            lblAtores.Text = "Atores:";
            // 
            // lblNacionalidade
            // 
            lblNacionalidade.AutoSize = true;
            lblNacionalidade.Location = new Point(143, 77);
            lblNacionalidade.Name = "lblNacionalidade";
            lblNacionalidade.Size = new Size(86, 15);
            lblNacionalidade.TabIndex = 8;
            lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(186, 35);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // lblAnoLancamento
            // 
            lblAnoLancamento.AutoSize = true;
            lblAnoLancamento.Location = new Point(143, 128);
            lblAnoLancamento.Name = "lblAnoLancamento";
            lblAnoLancamento.Size = new Size(114, 15);
            lblAnoLancamento.TabIndex = 14;
            lblAnoLancamento.Text = "Ano de lançamento:";
            // 
            // numAnoLancamento
            // 
            numAnoLancamento.Location = new Point(269, 126);
            numAnoLancamento.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numAnoLancamento.Name = "numAnoLancamento";
            numAnoLancamento.Size = new Size(120, 23);
            numAnoLancamento.TabIndex = 15;
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // frmEditarFilmes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 529);
            Controls.Add(numAnoLancamento);
            Controls.Add(lblAnoLancamento);
            Controls.Add(btSalvar);
            Controls.Add(dgvAtores);
            Controls.Add(cbxPais);
            Controls.Add(txtNome);
            Controls.Add(lblAtores);
            Controls.Add(lblNacionalidade);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEditarFilmes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditarFilmes";
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private DataGridView dgvAtores;
        private ComboBox cbxPais;
        private TextBox txtNome;
        private Label lblAtores;
        private Label lblNacionalidade;
        private Label lblNome;
        private Label lblAnoLancamento;
        private NumericUpDown numAnoLancamento;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
    }
}