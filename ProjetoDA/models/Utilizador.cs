using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.modelos
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }

        public Utilizador() { }

        public Utilizador(string username, string nome, string password)
        {
            Username = username;
            Nome = nome;
            Password = password;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}

