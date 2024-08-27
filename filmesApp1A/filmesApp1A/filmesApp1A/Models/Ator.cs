using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp1A.Models
{
    public class Ator
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public virtual List<Filme> Filmes { get; set; }
        public virtual Pais Nacionalidade { get; set; }

        public Ator()
        {
            nome = "";
            Filmes = new List<Filme>();
            Nacionalidade = new Pais();
        }
    }
}
