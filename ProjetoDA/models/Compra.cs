using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public class Compra
    {
        public Compra() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Estado { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public Utilizador CriadoPor { get; set; }
        public Utilizador AlteradoPor { get; set; }
    }
}
