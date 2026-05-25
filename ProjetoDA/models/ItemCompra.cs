using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public class ItemCompra
    {
        public ItemCompra() { }
        public int Id { get; set; }
        public Compra Compra { get; set; }
        public Artigo Artigo { get; set; }
        public int IsPrevisto { get; set; }
        public float QuantidadePrevista { get; set; }
        public float QuantidadeReal { get; set; }
        public float PrecoUnitario { get; set; }
        public string Observacoes { get; set; } = string.Empty;

    }
}
