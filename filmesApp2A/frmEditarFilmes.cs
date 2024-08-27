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
    public partial class frmEditarFilmes : Form
    {
        Filme filme;
        Contexto db;
        public frmEditarFilmes(Filme filme)
        {
            InitializeComponent();

            this.filme = filme;
            this.db = new Contexto();

            txtNome.Text = filme.Nome;
            numAnoLancamento.Value = filme.AnoLancamento;

            List<Pais> paises = this.db.Pais.ToList();
            cbxPais.DataSource = paises;

            cbxPais.SelectedIndex =
                cbxPais.FindStringExact(filme.Nacionalidade.Nome);

            dgvAtores.DataSource = filme.Atores;
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            filme.Nome = txtNome.Text;
            filme.AnoLancamento = (int)numAnoLancamento.Value;
            Pais pais = this.db.Pais
                        .Where(p => p.Nome == cbxPais.SelectedItem.ToString())
                        .First();
            filme.Nacionalidade = pais;

            this.db.Filme.Update(filme);
            this.db.SaveChanges();
            MessageBox.Show("Sucesso!");

        }
    }
}
