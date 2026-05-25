using ProjetoDA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.controllers
{
    internal class UtilizadorController
    {
        public List<Utilizador> getUtilizadores()
        {
            using (var db = new ShoppingContext())
            {
                return db.Utilizadores.ToList();
            }
        }

        public bool adicionarUtilizador(string username, string nome, string password)
        {
            using (var db = new ShoppingContext())
            {
                // Regra 4: O campo "Username" deverá ser único
                if (db.Utilizadores.Any(u => u.Username == username))
                    return false;

                Utilizador novo = new Utilizador(username, nome, password);
                db.Utilizadores.Add(novo);
                db.SaveChanges();
                return true;
            }
        }

        public bool editarUtilizador(int id, string nome, string password)
        {
            using (var db = new ShoppingContext())
            {
                Utilizador user = db.Utilizadores.FirstOrDefault(u => u.Id == id);
                if (user == null) return false;

                user.Nome = nome;
                user.Password = password;
                db.SaveChanges();
                return true;
            }
        }

        public bool removerUtilizador(int id)
        {
            using (var db = new ShoppingContext())
            {
                Utilizador user = db.Utilizadores.FirstOrDefault(u => u.Id == id);
                if (user == null) return false;

                db.Utilizadores.Remove(user);
                db.SaveChanges();
                return true;
            }
        }
    }
}
