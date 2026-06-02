using System;
using System.Linq;
using ProjetoDA.modelos;

namespace ProjetoDA.controllers
{
    internal class LoginController
    {
        /// <summary>
        /// Autentica um utilizador verificando username e password.
        /// </summary>
        /// <param name="username">Nome de utilizador</param>
        /// <param name="password">Palavra-passe do utilizador</param>
        /// <returns>ID do utilizador se autenticado com sucesso, caso contrário retorna -1</returns>
        public int AutenticarUtilizador(string username, string password)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return -1;
            }

            try
            {
                using (var db = new ShoppingContext())
                {
                    // Procura o utilizador pelo username e password
                    Utilizador utilizador = db.Utilizadores.FirstOrDefault(u => 
                        u.Username == username && u.Password == password);

                    // Retorna o ID se encontrado, caso contrário retorna -1
                    return utilizador != null ? utilizador.Id : -1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao autenticar utilizador: {ex.Message}");
                return -1;
            }
        }
    }
}
