using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public class Artigo
    {
        public Artigo()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoArtigo TipoArtigo { get; set; }
    }
}
