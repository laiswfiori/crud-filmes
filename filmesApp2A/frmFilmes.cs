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
    public partial class frmFilmes : Form
    {
        Contexto db;
        Form anterior;
        public frmFilmes(Form anterior)
        {
            InitializeComponent();

            this.anterior = anterior;

            this.db = new Contexto();
            this.db.Database.EnsureCreated();
            Recarregar("");
        }

        public void Recarregar(string busca)
        {
            List<Filme> filmes = this.db.Filme
                .Where(f => f.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList();

            dgvFilmes.DataSource = filmes;
        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoFilme f = new frmNovoFilme();
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        Filme selecionadoF;

        private void dgvFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFilmes.SelectedCells[0].RowIndex;
            int id = (int)dgvFilmes.Rows[linha].Cells[0].Value;

            selecionadoF = this.db.Filme.Where(f => f.Id == id).First();

            btEditar.Enabled = true;
            btRemover.Enabled = true;
            btElenco.Enabled = true;

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
           "Deseja mesmo remover o filme " + selecionadoF.Nome + "?",
           "Confirmação",
           MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Filme.Remove(selecionadoF);
                this.db.SaveChanges();

                btEditar.Enabled = false;
                btRemover.Enabled = false;
                btElenco.Enabled = false;

                Recarregar(txtBusca.Text);
            }
        }

        private void frmFilmes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
            anterior.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarFilmes f = new frmEditarFilmes(selecionadoF);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btElenco_Click(object sender, EventArgs e)
        {
            frmElenco f = new frmElenco(this.db, selecionadoF);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }
    }
}
