using ProjetoDA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public class Compra
    {
        public int Id { get; set; }
        public string NomeCompra { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFechada { get; set; } // Nullable, pois pode estar aberta
        public bool Fechada { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime? DataAlteracao { get; set; }

        // Relações com o Utilizador indicadas no diagrama
        public Utilizador UserCria { get; set; }
        public Utilizador UserEdita { get; set; }
        public Utilizador UserFecha { get; set; }

        public Compra() { }

        public override string ToString()
        {
            return NomeCompra;
        }
    }
}
