using filmesApp2A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp2A
{
    public partial class frmElenco : Form
    {
        Contexto db;
        Filme filme;

        public frmElenco(Contexto db, Filme filme)
        {
            InitializeComponent();

            this.db = db;
            this.db.Database.EnsureCreated();
            this.filme = filme;

            Recarregar("");
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoElenco f = new frmNovoElenco(this.db, this.filme);
            f.ShowDialog();
            Recarregar("");
        }

        Ator selecionadoA;

        private void dgvElenco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvElenco.SelectedCells[0].RowIndex;
            int id = (int)dgvElenco.Rows[linha].Cells[0].Value;

            selecionadoA = this.db.Ator.Where(a => a.Id == id).First();

            btRemover.Enabled = true;

            Recarregar("");
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover o ator " + selecionadoA.Nome + " do elenco?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.filme.Atores.Remove(selecionadoA);
                this.db.Filme.Update(filme);
                this.db.SaveChanges();

                btRemover.Enabled = false;

                Recarregar("");
            }

        }

        public void Recarregar(string busca)
        {
            List<Ator> atores = this.db.Ator.Where(a => a.Filmes.Contains(filme)).ToList();
            dgvElenco.DataSource = atores;
        }

        private void frmElenco_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
