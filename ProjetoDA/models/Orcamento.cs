using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public class Orcamento
    {
        public Orcamento() { }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Valor { get; set; }
        public Utilizador CriadoPor { get; set; }
        public Utilizador AprovadoPor { get; set; } = null;
    }
}
