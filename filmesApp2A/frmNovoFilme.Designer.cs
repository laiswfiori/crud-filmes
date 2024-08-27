namespace filmesApp2A
{
    partial class frmNovoFilme
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
            numAnoLancamento = new NumericUpDown();
            lblAnoLancamento = new Label();
            cbxPais = new ComboBox();
            txtNome = new TextBox();
            lblNacionalidade = new Label();
            lblNome = new Label();
            btCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).BeginInit();
            SuspendLayout();
            // 
            // numAnoLancamento
            // 
            numAnoLancamento.Location = new Point(150, 113);
            numAnoLancamento.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numAnoLancamento.Name = "numAnoLancamento";
            numAnoLancamento.Size = new Size(120, 23);
            numAnoLancamento.TabIndex = 21;
            // 
            // lblAnoLancamento
            // 
            lblAnoLancamento.AutoSize = true;
            lblAnoLancamento.Location = new Point(24, 115);
            lblAnoLancamento.Name = "lblAnoLancamento";
            lblAnoLancamento.Size = new Size(114, 15);
            lblAnoLancamento.TabIndex = 20;
            lblAnoLancamento.Text = "Ano de lançamento:";
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(116, 62);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(197, 23);
            cbxPais.TabIndex = 19;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(116, 14);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 18;
            // 
            // lblNacionalidade
            // 
            lblNacionalidade.AutoSize = true;
            lblNacionalidade.Location = new Point(24, 64);
            lblNacionalidade.Name = "lblNacionalidade";
            lblNacionalidade.Size = new Size(86, 15);
            lblNacionalidade.TabIndex = 17;
            lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(67, 22);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 16;
            lblNome.Text = "Nome:";
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(131, 164);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 22;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 226);
            Controls.Add(btCadastrar);
            Controls.Add(numAnoLancamento);
            Controls.Add(lblAnoLancamento);
            Controls.Add(cbxPais);
            Controls.Add(txtNome);
            Controls.Add(lblNacionalidade);
            Controls.Add(lblNome);
            Name = "frmNovoFilme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNovoFilme";
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numAnoLancamento;
        private Label lblAnoLancamento;
        private ComboBox cbxPais;
        private TextBox txtNome;
        private Label lblNacionalidade;
        private Label lblNome;
        private Button btCadastrar;
    }
}