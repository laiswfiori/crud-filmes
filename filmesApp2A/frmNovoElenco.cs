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
    public partial class frmNovoElenco : Form
    {
        Contexto db;
        Filme filme;
        public frmNovoElenco(Contexto db, Filme filme)
        {
            InitializeComponent();


            this.db = db;
            this.filme = filme;
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            Ator? ator = this.db.Ator.Where(a => a.Nome.ToUpper() == nome.ToUpper()).FirstOrDefault();

            if (ator != null) { 
                 filme.Atores.Add(ator);
                db.Filme.Update(filme);
                db.SaveChanges();

                MessageBox.Show("Sucesso!");

            }
            else {
                MessageBox.Show("Ator não existe.");
            }
           
        }

    }
}
