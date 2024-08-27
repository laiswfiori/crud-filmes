using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp1A.Models
{
    public class Filme
    {
        private int id;
        private string nome;
        private int anoLancamento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int AnoLancamento { get => anoLancamento; set => anoLancamento = value; }
        public virtual List<Ator> Atores { get; set; }
        public virtual Pais Nacionalidade { get; set; }

        public Filme()
        {
            nome = "";
            Atores = new List<Ator>();
            Nacionalidade = new Pais();
        }
    }
}
