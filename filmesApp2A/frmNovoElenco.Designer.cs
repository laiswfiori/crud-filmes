namespace filmesApp2A
{
    partial class frmNovoElenco
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
            btInserir = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btInserir
            // 
            btInserir.Location = new Point(204, 86);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(75, 23);
            btInserir.TabIndex = 9;
            btInserir.Text = "Inserir";
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(319, 23);
            txtNome.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome:";
            // 
            // frmNovoElenco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 165);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btInserir);
            Name = "frmNovoElenco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNovoElenco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btInserir;
        private TextBox txtNome;
        private Label label1;
    }
}