using filmesApp1A.Models;

namespace filmesApp1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contexto db;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();

            this.db.Database.EnsureCreated();

            /* Pais p = this.db.Pais.Where(pais => pais.Id == 1).First();

             Ator a = new Ator();
             a.Nome = "Robert Downey Jr.";
             a.Nacionalidade = p;

             this.db.Ator.Add(a);
             this.db.SaveChanges();
            */
            /*
            Ator a = this.db.Ator.Where(ator => ator.Id == 1).First();
            a.Nome = "Tom Holland";
            this.db.Ator.Update(a);
            this.db.SaveChanges();

            Filme f = new Filme();
            f.Nome = "Homem-Aranha: Roubaram minha casa";
            f.AnoLancamento = 2027;
            f.Atores.Add(a);

            this.db.Filme.Add(f);
            this.db.SaveChanges();
            */
            List<Ator> atores = this.db.Ator.ToList();
            dgvAtores.DataSource = atores;

           // this.db.Dispose();
        }
    }
}
