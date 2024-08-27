using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp1A.Models
{
    public class Pais
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public virtual List<Ator> Atores { get; set; }
        public virtual List<Filme> Filmes { get; set; }

        public Pais() {
            nome = "";
            Atores = new List<Ator>();
            Filmes = new List<Filme>();
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
